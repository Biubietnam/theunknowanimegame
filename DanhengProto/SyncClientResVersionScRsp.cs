using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200126F RID: 4719
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncClientResVersionScRsp : IMessage<SyncClientResVersionScRsp>, IMessage, IEquatable<SyncClientResVersionScRsp>, IDeepCloneable<SyncClientResVersionScRsp>, IBufferMessage
	{
		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x0600D2A4 RID: 53924 RVA: 0x00232C8D File Offset: 0x00230E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncClientResVersionScRsp> Parser
		{
			get
			{
				return SyncClientResVersionScRsp._parser;
			}
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x0600D2A5 RID: 53925 RVA: 0x00232C94 File Offset: 0x00230E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncClientResVersionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x0600D2A6 RID: 53926 RVA: 0x00232CA6 File Offset: 0x00230EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncClientResVersionScRsp.Descriptor;
			}
		}

		// Token: 0x0600D2A7 RID: 53927 RVA: 0x00232CAD File Offset: 0x00230EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncClientResVersionScRsp()
		{
		}

		// Token: 0x0600D2A8 RID: 53928 RVA: 0x00232CB5 File Offset: 0x00230EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncClientResVersionScRsp(SyncClientResVersionScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.resVersion_ = other.resVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D2A9 RID: 53929 RVA: 0x00232CE6 File Offset: 0x00230EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncClientResVersionScRsp Clone()
		{
			return new SyncClientResVersionScRsp(this);
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x0600D2AA RID: 53930 RVA: 0x00232CEE File Offset: 0x00230EEE
		// (set) Token: 0x0600D2AB RID: 53931 RVA: 0x00232CF6 File Offset: 0x00230EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x0600D2AC RID: 53932 RVA: 0x00232CFF File Offset: 0x00230EFF
		// (set) Token: 0x0600D2AD RID: 53933 RVA: 0x00232D07 File Offset: 0x00230F07
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

		// Token: 0x0600D2AE RID: 53934 RVA: 0x00232D10 File Offset: 0x00230F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncClientResVersionScRsp);
		}

		// Token: 0x0600D2AF RID: 53935 RVA: 0x00232D1E File Offset: 0x00230F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncClientResVersionScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.ResVersion == other.ResVersion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D2B0 RID: 53936 RVA: 0x00232D5C File Offset: 0x00230F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
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

		// Token: 0x0600D2B1 RID: 53937 RVA: 0x00232DB4 File Offset: 0x00230FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D2B2 RID: 53938 RVA: 0x00232DBC File Offset: 0x00230FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D2B3 RID: 53939 RVA: 0x00232DC8 File Offset: 0x00230FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ResVersion != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ResVersion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D2B4 RID: 53940 RVA: 0x00232E24 File Offset: 0x00231024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
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

		// Token: 0x0600D2B5 RID: 53941 RVA: 0x00232E7C File Offset: 0x0023107C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncClientResVersionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ResVersion != 0U)
			{
				this.ResVersion = other.ResVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D2B6 RID: 53942 RVA: 0x00232ECC File Offset: 0x002310CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D2B7 RID: 53943 RVA: 0x00232ED8 File Offset: 0x002310D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ResVersion = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005463 RID: 21603
		private static readonly MessageParser<SyncClientResVersionScRsp> _parser = new MessageParser<SyncClientResVersionScRsp>(() => new SyncClientResVersionScRsp());

		// Token: 0x04005464 RID: 21604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005465 RID: 21605
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04005466 RID: 21606
		private uint retcode_;

		// Token: 0x04005467 RID: 21607
		public const int ResVersionFieldNumber = 15;

		// Token: 0x04005468 RID: 21608
		private uint resVersion_;
	}
}
