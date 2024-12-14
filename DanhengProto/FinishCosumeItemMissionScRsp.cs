using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200056F RID: 1391
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishCosumeItemMissionScRsp : IMessage<FinishCosumeItemMissionScRsp>, IMessage, IEquatable<FinishCosumeItemMissionScRsp>, IDeepCloneable<FinishCosumeItemMissionScRsp>, IBufferMessage
	{
		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x000A9C9D File Offset: 0x000A7E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishCosumeItemMissionScRsp> Parser
		{
			get
			{
				return FinishCosumeItemMissionScRsp._parser;
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06003E0D RID: 15885 RVA: 0x000A9CA4 File Offset: 0x000A7EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishCosumeItemMissionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06003E0E RID: 15886 RVA: 0x000A9CB6 File Offset: 0x000A7EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishCosumeItemMissionScRsp.Descriptor;
			}
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x000A9CBD File Offset: 0x000A7EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCosumeItemMissionScRsp()
		{
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x000A9CC5 File Offset: 0x000A7EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCosumeItemMissionScRsp(FinishCosumeItemMissionScRsp other) : this()
		{
			this.subMissionId_ = other.subMissionId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x000A9CF6 File Offset: 0x000A7EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCosumeItemMissionScRsp Clone()
		{
			return new FinishCosumeItemMissionScRsp(this);
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x000A9CFE File Offset: 0x000A7EFE
		// (set) Token: 0x06003E13 RID: 15891 RVA: 0x000A9D06 File Offset: 0x000A7F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SubMissionId
		{
			get
			{
				return this.subMissionId_;
			}
			set
			{
				this.subMissionId_ = value;
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x000A9D0F File Offset: 0x000A7F0F
		// (set) Token: 0x06003E15 RID: 15893 RVA: 0x000A9D17 File Offset: 0x000A7F17
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

		// Token: 0x06003E16 RID: 15894 RVA: 0x000A9D20 File Offset: 0x000A7F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishCosumeItemMissionScRsp);
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x000A9D2E File Offset: 0x000A7F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishCosumeItemMissionScRsp other)
		{
			return other != null && (other == this || (this.SubMissionId == other.SubMissionId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x000A9D6C File Offset: 0x000A7F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubMissionId != 0U)
			{
				num ^= this.SubMissionId.GetHashCode();
			}
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

		// Token: 0x06003E19 RID: 15897 RVA: 0x000A9DC4 File Offset: 0x000A7FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x000A9DCC File Offset: 0x000A7FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x000A9DD8 File Offset: 0x000A7FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubMissionId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.SubMissionId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x000A9E34 File Offset: 0x000A8034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubMissionId);
			}
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

		// Token: 0x06003E1D RID: 15901 RVA: 0x000A9E8C File Offset: 0x000A808C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishCosumeItemMissionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubMissionId != 0U)
			{
				this.SubMissionId = other.SubMissionId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x000A9EDC File Offset: 0x000A80DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x000A9EE8 File Offset: 0x000A80E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.SubMissionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040018CB RID: 6347
		private static readonly MessageParser<FinishCosumeItemMissionScRsp> _parser = new MessageParser<FinishCosumeItemMissionScRsp>(() => new FinishCosumeItemMissionScRsp());

		// Token: 0x040018CC RID: 6348
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018CD RID: 6349
		public const int SubMissionIdFieldNumber = 9;

		// Token: 0x040018CE RID: 6350
		private uint subMissionId_;

		// Token: 0x040018CF RID: 6351
		public const int RetcodeFieldNumber = 14;

		// Token: 0x040018D0 RID: 6352
		private uint retcode_;
	}
}
