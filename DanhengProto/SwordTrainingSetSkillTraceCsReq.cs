using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001249 RID: 4681
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingSetSkillTraceCsReq : IMessage<SwordTrainingSetSkillTraceCsReq>, IMessage, IEquatable<SwordTrainingSetSkillTraceCsReq>, IDeepCloneable<SwordTrainingSetSkillTraceCsReq>, IBufferMessage
	{
		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x0600D10B RID: 53515 RVA: 0x0022F5E0 File Offset: 0x0022D7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingSetSkillTraceCsReq> Parser
		{
			get
			{
				return SwordTrainingSetSkillTraceCsReq._parser;
			}
		}

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x0600D10C RID: 53516 RVA: 0x0022F5E7 File Offset: 0x0022D7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingSetSkillTraceCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x0600D10D RID: 53517 RVA: 0x0022F5F9 File Offset: 0x0022D7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingSetSkillTraceCsReq.Descriptor;
			}
		}

		// Token: 0x0600D10E RID: 53518 RVA: 0x0022F600 File Offset: 0x0022D800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSetSkillTraceCsReq()
		{
		}

		// Token: 0x0600D10F RID: 53519 RVA: 0x0022F608 File Offset: 0x0022D808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSetSkillTraceCsReq(SwordTrainingSetSkillTraceCsReq other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D110 RID: 53520 RVA: 0x0022F62D File Offset: 0x0022D82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSetSkillTraceCsReq Clone()
		{
			return new SwordTrainingSetSkillTraceCsReq(this);
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x0600D111 RID: 53521 RVA: 0x0022F635 File Offset: 0x0022D835
		// (set) Token: 0x0600D112 RID: 53522 RVA: 0x0022F63D File Offset: 0x0022D83D
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

		// Token: 0x0600D113 RID: 53523 RVA: 0x0022F646 File Offset: 0x0022D846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingSetSkillTraceCsReq);
		}

		// Token: 0x0600D114 RID: 53524 RVA: 0x0022F654 File Offset: 0x0022D854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingSetSkillTraceCsReq other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D115 RID: 53525 RVA: 0x0022F684 File Offset: 0x0022D884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D116 RID: 53526 RVA: 0x0022F6C3 File Offset: 0x0022D8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D117 RID: 53527 RVA: 0x0022F6CB File Offset: 0x0022D8CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D118 RID: 53528 RVA: 0x0022F6D4 File Offset: 0x0022D8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D119 RID: 53529 RVA: 0x0022F708 File Offset: 0x0022D908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D11A RID: 53530 RVA: 0x0022F746 File Offset: 0x0022D946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingSetSkillTraceCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D11B RID: 53531 RVA: 0x0022F777 File Offset: 0x0022D977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D11C RID: 53532 RVA: 0x0022F780 File Offset: 0x0022D980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053EE RID: 21486
		private static readonly MessageParser<SwordTrainingSetSkillTraceCsReq> _parser = new MessageParser<SwordTrainingSetSkillTraceCsReq>(() => new SwordTrainingSetSkillTraceCsReq());

		// Token: 0x040053EF RID: 21487
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053F0 RID: 21488
		public const int SkillIdFieldNumber = 4;

		// Token: 0x040053F1 RID: 21489
		private uint skillId_;
	}
}
