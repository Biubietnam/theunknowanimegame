using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F93 RID: 3987
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournDeleteArchiveCsReq : IMessage<RogueTournDeleteArchiveCsReq>, IMessage, IEquatable<RogueTournDeleteArchiveCsReq>, IDeepCloneable<RogueTournDeleteArchiveCsReq>, IBufferMessage
	{
		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600B1A9 RID: 45481 RVA: 0x001DDBFC File Offset: 0x001DBDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournDeleteArchiveCsReq> Parser
		{
			get
			{
				return RogueTournDeleteArchiveCsReq._parser;
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600B1AA RID: 45482 RVA: 0x001DDC03 File Offset: 0x001DBE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournDeleteArchiveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600B1AB RID: 45483 RVA: 0x001DDC15 File Offset: 0x001DBE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournDeleteArchiveCsReq.Descriptor;
			}
		}

		// Token: 0x0600B1AC RID: 45484 RVA: 0x001DDC1C File Offset: 0x001DBE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDeleteArchiveCsReq()
		{
		}

		// Token: 0x0600B1AD RID: 45485 RVA: 0x001DDC24 File Offset: 0x001DBE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDeleteArchiveCsReq(RogueTournDeleteArchiveCsReq other) : this()
		{
			this.maxTimes_ = other.maxTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1AE RID: 45486 RVA: 0x001DDC49 File Offset: 0x001DBE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDeleteArchiveCsReq Clone()
		{
			return new RogueTournDeleteArchiveCsReq(this);
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600B1AF RID: 45487 RVA: 0x001DDC51 File Offset: 0x001DBE51
		// (set) Token: 0x0600B1B0 RID: 45488 RVA: 0x001DDC59 File Offset: 0x001DBE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxTimes
		{
			get
			{
				return this.maxTimes_;
			}
			set
			{
				this.maxTimes_ = value;
			}
		}

		// Token: 0x0600B1B1 RID: 45489 RVA: 0x001DDC62 File Offset: 0x001DBE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournDeleteArchiveCsReq);
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x001DDC70 File Offset: 0x001DBE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournDeleteArchiveCsReq other)
		{
			return other != null && (other == this || (this.MaxTimes == other.MaxTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1B3 RID: 45491 RVA: 0x001DDCA0 File Offset: 0x001DBEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxTimes != 0U)
			{
				num ^= this.MaxTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1B4 RID: 45492 RVA: 0x001DDCDF File Offset: 0x001DBEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B1B5 RID: 45493 RVA: 0x001DDCE7 File Offset: 0x001DBEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1B6 RID: 45494 RVA: 0x001DDCF0 File Offset: 0x001DBEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxTimes != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MaxTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x001DDD24 File Offset: 0x001DBF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x001DDD62 File Offset: 0x001DBF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournDeleteArchiveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxTimes != 0U)
			{
				this.MaxTimes = other.MaxTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x001DDD93 File Offset: 0x001DBF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1BA RID: 45498 RVA: 0x001DDD9C File Offset: 0x001DBF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MaxTimes = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400484A RID: 18506
		private static readonly MessageParser<RogueTournDeleteArchiveCsReq> _parser = new MessageParser<RogueTournDeleteArchiveCsReq>(() => new RogueTournDeleteArchiveCsReq());

		// Token: 0x0400484B RID: 18507
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400484C RID: 18508
		public const int MaxTimesFieldNumber = 2;

		// Token: 0x0400484D RID: 18509
		private uint maxTimes_;
	}
}
