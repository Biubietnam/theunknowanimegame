using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001121 RID: 4385
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetPlayerInfoCsReq : IMessage<SetPlayerInfoCsReq>, IMessage, IEquatable<SetPlayerInfoCsReq>, IDeepCloneable<SetPlayerInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x0600C382 RID: 50050 RVA: 0x0020CA8D File Offset: 0x0020AC8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetPlayerInfoCsReq> Parser
		{
			get
			{
				return SetPlayerInfoCsReq._parser;
			}
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x0600C383 RID: 50051 RVA: 0x0020CA94 File Offset: 0x0020AC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetPlayerInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x0600C384 RID: 50052 RVA: 0x0020CAA6 File Offset: 0x0020ACA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetPlayerInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600C385 RID: 50053 RVA: 0x0020CAAD File Offset: 0x0020ACAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerInfoCsReq()
		{
		}

		// Token: 0x0600C386 RID: 50054 RVA: 0x0020CAC0 File Offset: 0x0020ACC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerInfoCsReq(SetPlayerInfoCsReq other) : this()
		{
			this.isModify_ = other.isModify_;
			this.gender_ = other.gender_;
			this.nickname_ = other.nickname_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C387 RID: 50055 RVA: 0x0020CAFD File Offset: 0x0020ACFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerInfoCsReq Clone()
		{
			return new SetPlayerInfoCsReq(this);
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x0600C388 RID: 50056 RVA: 0x0020CB05 File Offset: 0x0020AD05
		// (set) Token: 0x0600C389 RID: 50057 RVA: 0x0020CB0D File Offset: 0x0020AD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsModify
		{
			get
			{
				return this.isModify_;
			}
			set
			{
				this.isModify_ = value;
			}
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x0600C38A RID: 50058 RVA: 0x0020CB16 File Offset: 0x0020AD16
		// (set) Token: 0x0600C38B RID: 50059 RVA: 0x0020CB1E File Offset: 0x0020AD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Gender Gender
		{
			get
			{
				return this.gender_;
			}
			set
			{
				this.gender_ = value;
			}
		}

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x0600C38C RID: 50060 RVA: 0x0020CB27 File Offset: 0x0020AD27
		// (set) Token: 0x0600C38D RID: 50061 RVA: 0x0020CB2F File Offset: 0x0020AD2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Nickname
		{
			get
			{
				return this.nickname_;
			}
			set
			{
				this.nickname_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600C38E RID: 50062 RVA: 0x0020CB42 File Offset: 0x0020AD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetPlayerInfoCsReq);
		}

		// Token: 0x0600C38F RID: 50063 RVA: 0x0020CB50 File Offset: 0x0020AD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetPlayerInfoCsReq other)
		{
			return other != null && (other == this || (this.IsModify == other.IsModify && this.Gender == other.Gender && !(this.Nickname != other.Nickname) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C390 RID: 50064 RVA: 0x0020CBB0 File Offset: 0x0020ADB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsModify)
			{
				num ^= this.IsModify.GetHashCode();
			}
			if (this.Gender != Gender.None)
			{
				num ^= this.Gender.GetHashCode();
			}
			if (this.Nickname.Length != 0)
			{
				num ^= this.Nickname.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C391 RID: 50065 RVA: 0x0020CC29 File Offset: 0x0020AE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C392 RID: 50066 RVA: 0x0020CC31 File Offset: 0x0020AE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C393 RID: 50067 RVA: 0x0020CC3C File Offset: 0x0020AE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Gender != Gender.None)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Gender);
			}
			if (this.IsModify)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsModify);
			}
			if (this.Nickname.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Nickname);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C394 RID: 50068 RVA: 0x0020CCB8 File Offset: 0x0020AEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsModify)
			{
				num += 2;
			}
			if (this.Gender != Gender.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Gender);
			}
			if (this.Nickname.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Nickname);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C395 RID: 50069 RVA: 0x0020CD20 File Offset: 0x0020AF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetPlayerInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsModify)
			{
				this.IsModify = other.IsModify;
			}
			if (other.Gender != Gender.None)
			{
				this.Gender = other.Gender;
			}
			if (other.Nickname.Length != 0)
			{
				this.Nickname = other.Nickname;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C396 RID: 50070 RVA: 0x0020CD89 File Offset: 0x0020AF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C397 RID: 50071 RVA: 0x0020CD94 File Offset: 0x0020AF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 66U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Nickname = input.ReadString();
						}
					}
					else
					{
						this.IsModify = input.ReadBool();
					}
				}
				else
				{
					this.Gender = (Gender)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004EF9 RID: 20217
		private static readonly MessageParser<SetPlayerInfoCsReq> _parser = new MessageParser<SetPlayerInfoCsReq>(() => new SetPlayerInfoCsReq());

		// Token: 0x04004EFA RID: 20218
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EFB RID: 20219
		public const int IsModifyFieldNumber = 4;

		// Token: 0x04004EFC RID: 20220
		private bool isModify_;

		// Token: 0x04004EFD RID: 20221
		public const int GenderFieldNumber = 3;

		// Token: 0x04004EFE RID: 20222
		private Gender gender_;

		// Token: 0x04004EFF RID: 20223
		public const int NicknameFieldNumber = 8;

		// Token: 0x04004F00 RID: 20224
		private string nickname_ = "";
	}
}
