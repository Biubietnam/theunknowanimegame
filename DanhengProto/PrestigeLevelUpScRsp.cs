using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CFF RID: 3327
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrestigeLevelUpScRsp : IMessage<PrestigeLevelUpScRsp>, IMessage, IEquatable<PrestigeLevelUpScRsp>, IDeepCloneable<PrestigeLevelUpScRsp>, IBufferMessage
	{
		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x0600949B RID: 38043 RVA: 0x0018B0F8 File Offset: 0x001892F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrestigeLevelUpScRsp> Parser
		{
			get
			{
				return PrestigeLevelUpScRsp._parser;
			}
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x0600949C RID: 38044 RVA: 0x0018B0FF File Offset: 0x001892FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PrestigeLevelUpScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x0600949D RID: 38045 RVA: 0x0018B111 File Offset: 0x00189311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrestigeLevelUpScRsp.Descriptor;
			}
		}

		// Token: 0x0600949E RID: 38046 RVA: 0x0018B118 File Offset: 0x00189318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrestigeLevelUpScRsp()
		{
		}

		// Token: 0x0600949F RID: 38047 RVA: 0x0018B120 File Offset: 0x00189320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrestigeLevelUpScRsp(PrestigeLevelUpScRsp other) : this()
		{
			this.level_ = other.level_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094A0 RID: 38048 RVA: 0x0018B151 File Offset: 0x00189351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrestigeLevelUpScRsp Clone()
		{
			return new PrestigeLevelUpScRsp(this);
		}

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x060094A1 RID: 38049 RVA: 0x0018B159 File Offset: 0x00189359
		// (set) Token: 0x060094A2 RID: 38050 RVA: 0x0018B161 File Offset: 0x00189361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x060094A3 RID: 38051 RVA: 0x0018B16A File Offset: 0x0018936A
		// (set) Token: 0x060094A4 RID: 38052 RVA: 0x0018B172 File Offset: 0x00189372
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

		// Token: 0x060094A5 RID: 38053 RVA: 0x0018B17B File Offset: 0x0018937B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrestigeLevelUpScRsp);
		}

		// Token: 0x060094A6 RID: 38054 RVA: 0x0018B189 File Offset: 0x00189389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrestigeLevelUpScRsp other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094A7 RID: 38055 RVA: 0x0018B1C8 File Offset: 0x001893C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
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

		// Token: 0x060094A8 RID: 38056 RVA: 0x0018B220 File Offset: 0x00189420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x0018B228 File Offset: 0x00189428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094AA RID: 38058 RVA: 0x0018B234 File Offset: 0x00189434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094AB RID: 38059 RVA: 0x0018B290 File Offset: 0x00189490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
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

		// Token: 0x060094AC RID: 38060 RVA: 0x0018B2E8 File Offset: 0x001894E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrestigeLevelUpScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x0018B338 File Offset: 0x00189538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094AE RID: 38062 RVA: 0x0018B344 File Offset: 0x00189544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400398E RID: 14734
		private static readonly MessageParser<PrestigeLevelUpScRsp> _parser = new MessageParser<PrestigeLevelUpScRsp>(() => new PrestigeLevelUpScRsp());

		// Token: 0x0400398F RID: 14735
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003990 RID: 14736
		public const int LevelFieldNumber = 11;

		// Token: 0x04003991 RID: 14737
		private uint level_;

		// Token: 0x04003992 RID: 14738
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04003993 RID: 14739
		private uint retcode_;
	}
}
