using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001237 RID: 4663
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingLearnSkillScRsp : IMessage<SwordTrainingLearnSkillScRsp>, IMessage, IEquatable<SwordTrainingLearnSkillScRsp>, IDeepCloneable<SwordTrainingLearnSkillScRsp>, IBufferMessage
	{
		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x0600D04A RID: 53322 RVA: 0x0022DD79 File Offset: 0x0022BF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingLearnSkillScRsp> Parser
		{
			get
			{
				return SwordTrainingLearnSkillScRsp._parser;
			}
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x0600D04B RID: 53323 RVA: 0x0022DD80 File Offset: 0x0022BF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingLearnSkillScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x0600D04C RID: 53324 RVA: 0x0022DD92 File Offset: 0x0022BF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingLearnSkillScRsp.Descriptor;
			}
		}

		// Token: 0x0600D04D RID: 53325 RVA: 0x0022DD99 File Offset: 0x0022BF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingLearnSkillScRsp()
		{
		}

		// Token: 0x0600D04E RID: 53326 RVA: 0x0022DDA1 File Offset: 0x0022BFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingLearnSkillScRsp(SwordTrainingLearnSkillScRsp other) : this()
		{
			this.skillId_ = other.skillId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D04F RID: 53327 RVA: 0x0022DDD2 File Offset: 0x0022BFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingLearnSkillScRsp Clone()
		{
			return new SwordTrainingLearnSkillScRsp(this);
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x0600D050 RID: 53328 RVA: 0x0022DDDA File Offset: 0x0022BFDA
		// (set) Token: 0x0600D051 RID: 53329 RVA: 0x0022DDE2 File Offset: 0x0022BFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x0600D052 RID: 53330 RVA: 0x0022DDEB File Offset: 0x0022BFEB
		// (set) Token: 0x0600D053 RID: 53331 RVA: 0x0022DDF3 File Offset: 0x0022BFF3
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

		// Token: 0x0600D054 RID: 53332 RVA: 0x0022DDFC File Offset: 0x0022BFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingLearnSkillScRsp);
		}

		// Token: 0x0600D055 RID: 53333 RVA: 0x0022DE0A File Offset: 0x0022C00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingLearnSkillScRsp other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D056 RID: 53334 RVA: 0x0022DE48 File Offset: 0x0022C048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
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

		// Token: 0x0600D057 RID: 53335 RVA: 0x0022DEA0 File Offset: 0x0022C0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D058 RID: 53336 RVA: 0x0022DEA8 File Offset: 0x0022C0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D059 RID: 53337 RVA: 0x0022DEB4 File Offset: 0x0022C0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D05A RID: 53338 RVA: 0x0022DF10 File Offset: 0x0022C110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
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

		// Token: 0x0600D05B RID: 53339 RVA: 0x0022DF68 File Offset: 0x0022C168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingLearnSkillScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D05C RID: 53340 RVA: 0x0022DFB8 File Offset: 0x0022C1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D05D RID: 53341 RVA: 0x0022DFC4 File Offset: 0x0022C1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053BD RID: 21437
		private static readonly MessageParser<SwordTrainingLearnSkillScRsp> _parser = new MessageParser<SwordTrainingLearnSkillScRsp>(() => new SwordTrainingLearnSkillScRsp());

		// Token: 0x040053BE RID: 21438
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053BF RID: 21439
		public const int SkillIdFieldNumber = 11;

		// Token: 0x040053C0 RID: 21440
		private uint skillId_;

		// Token: 0x040053C1 RID: 21441
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040053C2 RID: 21442
		private uint retcode_;
	}
}
