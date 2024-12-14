using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000429 RID: 1065
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnhanceRogueBuffScRsp : IMessage<EnhanceRogueBuffScRsp>, IMessage, IEquatable<EnhanceRogueBuffScRsp>, IDeepCloneable<EnhanceRogueBuffScRsp>, IBufferMessage
	{
		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002F55 RID: 12117 RVA: 0x000829ED File Offset: 0x00080BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnhanceRogueBuffScRsp> Parser
		{
			get
			{
				return EnhanceRogueBuffScRsp._parser;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x000829F4 File Offset: 0x00080BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnhanceRogueBuffScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002F57 RID: 12119 RVA: 0x00082A06 File Offset: 0x00080C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnhanceRogueBuffScRsp.Descriptor;
			}
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x00082A0D File Offset: 0x00080C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceRogueBuffScRsp()
		{
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x00082A18 File Offset: 0x00080C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceRogueBuffScRsp(EnhanceRogueBuffScRsp other) : this()
		{
			this.rogueBuff_ = ((other.rogueBuff_ != null) ? other.rogueBuff_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.isSuccess_ = other.isSuccess_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00082A70 File Offset: 0x00080C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceRogueBuffScRsp Clone()
		{
			return new EnhanceRogueBuffScRsp(this);
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x00082A78 File Offset: 0x00080C78
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x00082A80 File Offset: 0x00080C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuff RogueBuff
		{
			get
			{
				return this.rogueBuff_;
			}
			set
			{
				this.rogueBuff_ = value;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x00082A89 File Offset: 0x00080C89
		// (set) Token: 0x06002F5E RID: 12126 RVA: 0x00082A91 File Offset: 0x00080C91
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

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x00082A9A File Offset: 0x00080C9A
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x00082AA2 File Offset: 0x00080CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x00082AAB File Offset: 0x00080CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnhanceRogueBuffScRsp);
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x00082ABC File Offset: 0x00080CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnhanceRogueBuffScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueBuff, other.RogueBuff) && this.Retcode == other.Retcode && this.IsSuccess == other.IsSuccess && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x00082B1C File Offset: 0x00080D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueBuff_ != null)
			{
				num ^= this.RogueBuff.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x00082B8A File Offset: 0x00080D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x00082B92 File Offset: 0x00080D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00082B9C File Offset: 0x00080D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueBuff_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueBuff);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsSuccess);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x00082C14 File Offset: 0x00080E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueBuff_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuff);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x00082C78 File Offset: 0x00080E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnhanceRogueBuffScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueBuff_ != null)
			{
				if (this.rogueBuff_ == null)
				{
					this.RogueBuff = new RogueBuff();
				}
				this.RogueBuff.MergeFrom(other.RogueBuff);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x00082CF4 File Offset: 0x00080EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x00082D00 File Offset: 0x00080F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 56U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsSuccess = input.ReadBool();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.rogueBuff_ == null)
					{
						this.RogueBuff = new RogueBuff();
					}
					input.ReadMessage(this.RogueBuff);
				}
			}
		}

		// Token: 0x040012F4 RID: 4852
		private static readonly MessageParser<EnhanceRogueBuffScRsp> _parser = new MessageParser<EnhanceRogueBuffScRsp>(() => new EnhanceRogueBuffScRsp());

		// Token: 0x040012F5 RID: 4853
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012F6 RID: 4854
		public const int RogueBuffFieldNumber = 6;

		// Token: 0x040012F7 RID: 4855
		private RogueBuff rogueBuff_;

		// Token: 0x040012F8 RID: 4856
		public const int RetcodeFieldNumber = 7;

		// Token: 0x040012F9 RID: 4857
		private uint retcode_;

		// Token: 0x040012FA RID: 4858
		public const int IsSuccessFieldNumber = 13;

		// Token: 0x040012FB RID: 4859
		private bool isSuccess_;
	}
}
