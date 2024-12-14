using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200111F RID: 4383
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetNicknameScRsp : IMessage<SetNicknameScRsp>, IMessage, IEquatable<SetNicknameScRsp>, IDeepCloneable<SetNicknameScRsp>, IBufferMessage
	{
		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0600C369 RID: 50025 RVA: 0x0020C6A1 File Offset: 0x0020A8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetNicknameScRsp> Parser
		{
			get
			{
				return SetNicknameScRsp._parser;
			}
		}

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0600C36A RID: 50026 RVA: 0x0020C6A8 File Offset: 0x0020A8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetNicknameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0600C36B RID: 50027 RVA: 0x0020C6BA File Offset: 0x0020A8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetNicknameScRsp.Descriptor;
			}
		}

		// Token: 0x0600C36C RID: 50028 RVA: 0x0020C6C1 File Offset: 0x0020A8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNicknameScRsp()
		{
		}

		// Token: 0x0600C36D RID: 50029 RVA: 0x0020C6C9 File Offset: 0x0020A8C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNicknameScRsp(SetNicknameScRsp other) : this()
		{
			this.isModify_ = other.isModify_;
			this.retcode_ = other.retcode_;
			this.dLFJLAJMLHJ_ = other.dLFJLAJMLHJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C36E RID: 50030 RVA: 0x0020C706 File Offset: 0x0020A906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNicknameScRsp Clone()
		{
			return new SetNicknameScRsp(this);
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x0600C36F RID: 50031 RVA: 0x0020C70E File Offset: 0x0020A90E
		// (set) Token: 0x0600C370 RID: 50032 RVA: 0x0020C716 File Offset: 0x0020A916
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

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x0600C371 RID: 50033 RVA: 0x0020C71F File Offset: 0x0020A91F
		// (set) Token: 0x0600C372 RID: 50034 RVA: 0x0020C727 File Offset: 0x0020A927
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

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x0600C373 RID: 50035 RVA: 0x0020C730 File Offset: 0x0020A930
		// (set) Token: 0x0600C374 RID: 50036 RVA: 0x0020C738 File Offset: 0x0020A938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DLFJLAJMLHJ
		{
			get
			{
				return this.dLFJLAJMLHJ_;
			}
			set
			{
				this.dLFJLAJMLHJ_ = value;
			}
		}

		// Token: 0x0600C375 RID: 50037 RVA: 0x0020C741 File Offset: 0x0020A941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetNicknameScRsp);
		}

		// Token: 0x0600C376 RID: 50038 RVA: 0x0020C750 File Offset: 0x0020A950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetNicknameScRsp other)
		{
			return other != null && (other == this || (this.IsModify == other.IsModify && this.Retcode == other.Retcode && this.DLFJLAJMLHJ == other.DLFJLAJMLHJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C377 RID: 50039 RVA: 0x0020C7AC File Offset: 0x0020A9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsModify)
			{
				num ^= this.IsModify.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.DLFJLAJMLHJ != 0L)
			{
				num ^= this.DLFJLAJMLHJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C378 RID: 50040 RVA: 0x0020C81D File Offset: 0x0020AA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C379 RID: 50041 RVA: 0x0020C825 File Offset: 0x0020AA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C37A RID: 50042 RVA: 0x0020C830 File Offset: 0x0020AA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsModify)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsModify);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.DLFJLAJMLHJ != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.DLFJLAJMLHJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C37B RID: 50043 RVA: 0x0020C8A8 File Offset: 0x0020AAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsModify)
			{
				num += 2;
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.DLFJLAJMLHJ != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DLFJLAJMLHJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C37C RID: 50044 RVA: 0x0020C90C File Offset: 0x0020AB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetNicknameScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsModify)
			{
				this.IsModify = other.IsModify;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.DLFJLAJMLHJ != 0L)
			{
				this.DLFJLAJMLHJ = other.DLFJLAJMLHJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C37D RID: 50045 RVA: 0x0020C970 File Offset: 0x0020AB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C37E RID: 50046 RVA: 0x0020C97C File Offset: 0x0020AB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 64U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DLFJLAJMLHJ = input.ReadInt64();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.IsModify = input.ReadBool();
				}
			}
		}

		// Token: 0x04004EF0 RID: 20208
		private static readonly MessageParser<SetNicknameScRsp> _parser = new MessageParser<SetNicknameScRsp>(() => new SetNicknameScRsp());

		// Token: 0x04004EF1 RID: 20209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EF2 RID: 20210
		public const int IsModifyFieldNumber = 6;

		// Token: 0x04004EF3 RID: 20211
		private bool isModify_;

		// Token: 0x04004EF4 RID: 20212
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004EF5 RID: 20213
		private uint retcode_;

		// Token: 0x04004EF6 RID: 20214
		public const int DLFJLAJMLHJFieldNumber = 10;

		// Token: 0x04004EF7 RID: 20215
		private long dLFJLAJMLHJ_;
	}
}
