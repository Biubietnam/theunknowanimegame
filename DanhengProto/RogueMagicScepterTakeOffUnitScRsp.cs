using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F13 RID: 3859
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicScepterTakeOffUnitScRsp : IMessage<RogueMagicScepterTakeOffUnitScRsp>, IMessage, IEquatable<RogueMagicScepterTakeOffUnitScRsp>, IDeepCloneable<RogueMagicScepterTakeOffUnitScRsp>, IBufferMessage
	{
		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x0600AC44 RID: 44100 RVA: 0x001CFAEC File Offset: 0x001CDCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicScepterTakeOffUnitScRsp> Parser
		{
			get
			{
				return RogueMagicScepterTakeOffUnitScRsp._parser;
			}
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x0600AC45 RID: 44101 RVA: 0x001CFAF3 File Offset: 0x001CDCF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterTakeOffUnitScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x0600AC46 RID: 44102 RVA: 0x001CFB05 File Offset: 0x001CDD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicScepterTakeOffUnitScRsp.Descriptor;
			}
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x001CFB0C File Offset: 0x001CDD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterTakeOffUnitScRsp()
		{
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x001CFB14 File Offset: 0x001CDD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterTakeOffUnitScRsp(RogueMagicScepterTakeOffUnitScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x001CFB39 File Offset: 0x001CDD39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepterTakeOffUnitScRsp Clone()
		{
			return new RogueMagicScepterTakeOffUnitScRsp(this);
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x0600AC4A RID: 44106 RVA: 0x001CFB41 File Offset: 0x001CDD41
		// (set) Token: 0x0600AC4B RID: 44107 RVA: 0x001CFB49 File Offset: 0x001CDD49
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

		// Token: 0x0600AC4C RID: 44108 RVA: 0x001CFB52 File Offset: 0x001CDD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicScepterTakeOffUnitScRsp);
		}

		// Token: 0x0600AC4D RID: 44109 RVA: 0x001CFB60 File Offset: 0x001CDD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicScepterTakeOffUnitScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC4E RID: 44110 RVA: 0x001CFB90 File Offset: 0x001CDD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC4F RID: 44111 RVA: 0x001CFBCF File Offset: 0x001CDDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x001CFBD7 File Offset: 0x001CDDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC51 RID: 44113 RVA: 0x001CFBE0 File Offset: 0x001CDDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x001CFC14 File Offset: 0x001CDE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC53 RID: 44115 RVA: 0x001CFC52 File Offset: 0x001CDE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicScepterTakeOffUnitScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC54 RID: 44116 RVA: 0x001CFC83 File Offset: 0x001CDE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC55 RID: 44117 RVA: 0x001CFC8C File Offset: 0x001CDE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400463A RID: 17978
		private static readonly MessageParser<RogueMagicScepterTakeOffUnitScRsp> _parser = new MessageParser<RogueMagicScepterTakeOffUnitScRsp>(() => new RogueMagicScepterTakeOffUnitScRsp());

		// Token: 0x0400463B RID: 17979
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400463C RID: 17980
		public const int RetcodeFieldNumber = 7;

		// Token: 0x0400463D RID: 17981
		private uint retcode_;
	}
}
