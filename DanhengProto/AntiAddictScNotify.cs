using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000A5 RID: 165
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AntiAddictScNotify : IMessage<AntiAddictScNotify>, IMessage, IEquatable<AntiAddictScNotify>, IDeepCloneable<AntiAddictScNotify>, IBufferMessage
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00014114 File Offset: 0x00012314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AntiAddictScNotify> Parser
		{
			get
			{
				return AntiAddictScNotify._parser;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0001411B File Offset: 0x0001231B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AntiAddictScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0001412D File Offset: 0x0001232D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AntiAddictScNotify.Descriptor;
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00014134 File Offset: 0x00012334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AntiAddictScNotify()
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00014152 File Offset: 0x00012352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AntiAddictScNotify(AntiAddictScNotify other) : this()
		{
			this.level_ = other.level_;
			this.msgType_ = other.msgType_;
			this.msg_ = other.msg_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001418F File Offset: 0x0001238F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AntiAddictScNotify Clone()
		{
			return new AntiAddictScNotify(this);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00014197 File Offset: 0x00012397
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0001419F File Offset: 0x0001239F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000141B2 File Offset: 0x000123B2
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x000141BA File Offset: 0x000123BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MsgType
		{
			get
			{
				return this.msgType_;
			}
			set
			{
				this.msgType_ = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x000141C3 File Offset: 0x000123C3
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x000141CB File Offset: 0x000123CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Msg
		{
			get
			{
				return this.msg_;
			}
			set
			{
				this.msg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000141DE File Offset: 0x000123DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AntiAddictScNotify);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000141EC File Offset: 0x000123EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AntiAddictScNotify other)
		{
			return other != null && (other == this || (!(this.Level != other.Level) && this.MsgType == other.MsgType && !(this.Msg != other.Msg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00014250 File Offset: 0x00012450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level.Length != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MsgType != 0U)
			{
				num ^= this.MsgType.GetHashCode();
			}
			if (this.Msg.Length != 0)
			{
				num ^= this.Msg.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000142C5 File Offset: 0x000124C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000142CD File Offset: 0x000124CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000142D8 File Offset: 0x000124D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Msg.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Msg);
			}
			if (this.MsgType != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.MsgType);
			}
			if (this.Level.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00014358 File Offset: 0x00012558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Level);
			}
			if (this.MsgType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MsgType);
			}
			if (this.Msg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Msg);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000143D0 File Offset: 0x000125D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AntiAddictScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level.Length != 0)
			{
				this.Level = other.Level;
			}
			if (other.MsgType != 0U)
			{
				this.MsgType = other.MsgType;
			}
			if (other.Msg.Length != 0)
			{
				this.Msg = other.Msg;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0001443E File Offset: 0x0001263E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00014448 File Offset: 0x00012648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 88U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Level = input.ReadString();
						}
					}
					else
					{
						this.MsgType = input.ReadUInt32();
					}
				}
				else
				{
					this.Msg = input.ReadString();
				}
			}
		}

		// Token: 0x040002A1 RID: 673
		private static readonly MessageParser<AntiAddictScNotify> _parser = new MessageParser<AntiAddictScNotify>(() => new AntiAddictScNotify());

		// Token: 0x040002A2 RID: 674
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002A3 RID: 675
		public const int LevelFieldNumber = 15;

		// Token: 0x040002A4 RID: 676
		private string level_ = "";

		// Token: 0x040002A5 RID: 677
		public const int MsgTypeFieldNumber = 11;

		// Token: 0x040002A6 RID: 678
		private uint msgType_;

		// Token: 0x040002A7 RID: 679
		public const int MsgFieldNumber = 4;

		// Token: 0x040002A8 RID: 680
		private string msg_ = "";
	}
}
