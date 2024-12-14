using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200111D RID: 4381
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetNicknameCsReq : IMessage<SetNicknameCsReq>, IMessage, IEquatable<SetNicknameCsReq>, IDeepCloneable<SetNicknameCsReq>, IBufferMessage
	{
		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0600C352 RID: 50002 RVA: 0x0020C338 File Offset: 0x0020A538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetNicknameCsReq> Parser
		{
			get
			{
				return SetNicknameCsReq._parser;
			}
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0600C353 RID: 50003 RVA: 0x0020C33F File Offset: 0x0020A53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetNicknameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0600C354 RID: 50004 RVA: 0x0020C351 File Offset: 0x0020A551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetNicknameCsReq.Descriptor;
			}
		}

		// Token: 0x0600C355 RID: 50005 RVA: 0x0020C358 File Offset: 0x0020A558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNicknameCsReq()
		{
		}

		// Token: 0x0600C356 RID: 50006 RVA: 0x0020C36B File Offset: 0x0020A56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNicknameCsReq(SetNicknameCsReq other) : this()
		{
			this.isModify_ = other.isModify_;
			this.nickname_ = other.nickname_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C357 RID: 50007 RVA: 0x0020C39C File Offset: 0x0020A59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetNicknameCsReq Clone()
		{
			return new SetNicknameCsReq(this);
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0600C358 RID: 50008 RVA: 0x0020C3A4 File Offset: 0x0020A5A4
		// (set) Token: 0x0600C359 RID: 50009 RVA: 0x0020C3AC File Offset: 0x0020A5AC
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

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0600C35A RID: 50010 RVA: 0x0020C3B5 File Offset: 0x0020A5B5
		// (set) Token: 0x0600C35B RID: 50011 RVA: 0x0020C3BD File Offset: 0x0020A5BD
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

		// Token: 0x0600C35C RID: 50012 RVA: 0x0020C3D0 File Offset: 0x0020A5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetNicknameCsReq);
		}

		// Token: 0x0600C35D RID: 50013 RVA: 0x0020C3E0 File Offset: 0x0020A5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetNicknameCsReq other)
		{
			return other != null && (other == this || (this.IsModify == other.IsModify && !(this.Nickname != other.Nickname) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C35E RID: 50014 RVA: 0x0020C430 File Offset: 0x0020A630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsModify)
			{
				num ^= this.IsModify.GetHashCode();
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

		// Token: 0x0600C35F RID: 50015 RVA: 0x0020C48A File Offset: 0x0020A68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C360 RID: 50016 RVA: 0x0020C492 File Offset: 0x0020A692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C361 RID: 50017 RVA: 0x0020C49C File Offset: 0x0020A69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsModify)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsModify);
			}
			if (this.Nickname.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Nickname);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C362 RID: 50018 RVA: 0x0020C4FC File Offset: 0x0020A6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsModify)
			{
				num += 2;
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

		// Token: 0x0600C363 RID: 50019 RVA: 0x0020C54C File Offset: 0x0020A74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetNicknameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsModify)
			{
				this.IsModify = other.IsModify;
			}
			if (other.Nickname.Length != 0)
			{
				this.Nickname = other.Nickname;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C364 RID: 50020 RVA: 0x0020C5A1 File Offset: 0x0020A7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C365 RID: 50021 RVA: 0x0020C5AC File Offset: 0x0020A7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 34U)
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
		}

		// Token: 0x04004EE9 RID: 20201
		private static readonly MessageParser<SetNicknameCsReq> _parser = new MessageParser<SetNicknameCsReq>(() => new SetNicknameCsReq());

		// Token: 0x04004EEA RID: 20202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EEB RID: 20203
		public const int IsModifyFieldNumber = 2;

		// Token: 0x04004EEC RID: 20204
		private bool isModify_;

		// Token: 0x04004EED RID: 20205
		public const int NicknameFieldNumber = 4;

		// Token: 0x04004EEE RID: 20206
		private string nickname_ = "";
	}
}
