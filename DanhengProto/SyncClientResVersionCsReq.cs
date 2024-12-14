using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200126D RID: 4717
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncClientResVersionCsReq : IMessage<SyncClientResVersionCsReq>, IMessage, IEquatable<SyncClientResVersionCsReq>, IDeepCloneable<SyncClientResVersionCsReq>, IBufferMessage
	{
		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x0600D28F RID: 53903 RVA: 0x00232A14 File Offset: 0x00230C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncClientResVersionCsReq> Parser
		{
			get
			{
				return SyncClientResVersionCsReq._parser;
			}
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x0600D290 RID: 53904 RVA: 0x00232A1B File Offset: 0x00230C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncClientResVersionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x0600D291 RID: 53905 RVA: 0x00232A2D File Offset: 0x00230C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncClientResVersionCsReq.Descriptor;
			}
		}

		// Token: 0x0600D292 RID: 53906 RVA: 0x00232A34 File Offset: 0x00230C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncClientResVersionCsReq()
		{
		}

		// Token: 0x0600D293 RID: 53907 RVA: 0x00232A3C File Offset: 0x00230C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncClientResVersionCsReq(SyncClientResVersionCsReq other) : this()
		{
			this.resVersion_ = other.resVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D294 RID: 53908 RVA: 0x00232A61 File Offset: 0x00230C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncClientResVersionCsReq Clone()
		{
			return new SyncClientResVersionCsReq(this);
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x0600D295 RID: 53909 RVA: 0x00232A69 File Offset: 0x00230C69
		// (set) Token: 0x0600D296 RID: 53910 RVA: 0x00232A71 File Offset: 0x00230C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ResVersion
		{
			get
			{
				return this.resVersion_;
			}
			set
			{
				this.resVersion_ = value;
			}
		}

		// Token: 0x0600D297 RID: 53911 RVA: 0x00232A7A File Offset: 0x00230C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncClientResVersionCsReq);
		}

		// Token: 0x0600D298 RID: 53912 RVA: 0x00232A88 File Offset: 0x00230C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncClientResVersionCsReq other)
		{
			return other != null && (other == this || (this.ResVersion == other.ResVersion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D299 RID: 53913 RVA: 0x00232AB8 File Offset: 0x00230CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResVersion != 0U)
			{
				num ^= this.ResVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D29A RID: 53914 RVA: 0x00232AF7 File Offset: 0x00230CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D29B RID: 53915 RVA: 0x00232AFF File Offset: 0x00230CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D29C RID: 53916 RVA: 0x00232B08 File Offset: 0x00230D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResVersion != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ResVersion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D29D RID: 53917 RVA: 0x00232B3C File Offset: 0x00230D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResVersion != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ResVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D29E RID: 53918 RVA: 0x00232B7A File Offset: 0x00230D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncClientResVersionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResVersion != 0U)
			{
				this.ResVersion = other.ResVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D29F RID: 53919 RVA: 0x00232BAB File Offset: 0x00230DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2A0 RID: 53920 RVA: 0x00232BB4 File Offset: 0x00230DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ResVersion = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400545E RID: 21598
		private static readonly MessageParser<SyncClientResVersionCsReq> _parser = new MessageParser<SyncClientResVersionCsReq>(() => new SyncClientResVersionCsReq());

		// Token: 0x0400545F RID: 21599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005460 RID: 21600
		public const int ResVersionFieldNumber = 1;

		// Token: 0x04005461 RID: 21601
		private uint resVersion_;
	}
}
