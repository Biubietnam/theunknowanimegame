using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ACF RID: 2767
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MFKOBPLMPIN : IMessage<MFKOBPLMPIN>, IMessage, IEquatable<MFKOBPLMPIN>, IDeepCloneable<MFKOBPLMPIN>, IBufferMessage
	{
		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x06007A91 RID: 31377 RVA: 0x00144947 File Offset: 0x00142B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MFKOBPLMPIN> Parser
		{
			get
			{
				return MFKOBPLMPIN._parser;
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x06007A92 RID: 31378 RVA: 0x0014494E File Offset: 0x00142B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MFKOBPLMPINReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x06007A93 RID: 31379 RVA: 0x00144960 File Offset: 0x00142B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MFKOBPLMPIN.Descriptor;
			}
		}

		// Token: 0x06007A94 RID: 31380 RVA: 0x00144967 File Offset: 0x00142B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFKOBPLMPIN()
		{
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x0014496F File Offset: 0x00142B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFKOBPLMPIN(MFKOBPLMPIN other) : this()
		{
			this.bJBAKJGFBGA_ = other.bJBAKJGFBGA_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A96 RID: 31382 RVA: 0x001449A0 File Offset: 0x00142BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFKOBPLMPIN Clone()
		{
			return new MFKOBPLMPIN(this);
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x06007A97 RID: 31383 RVA: 0x001449A8 File Offset: 0x00142BA8
		// (set) Token: 0x06007A98 RID: 31384 RVA: 0x001449B0 File Offset: 0x00142BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyCharacterType BJBAKJGFBGA
		{
			get
			{
				return this.bJBAKJGFBGA_;
			}
			set
			{
				this.bJBAKJGFBGA_ = value;
			}
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x06007A99 RID: 31385 RVA: 0x001449B9 File Offset: 0x00142BB9
		// (set) Token: 0x06007A9A RID: 31386 RVA: 0x001449C1 File Offset: 0x00142BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyCharacterStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x001449CA File Offset: 0x00142BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MFKOBPLMPIN);
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x001449D8 File Offset: 0x00142BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MFKOBPLMPIN other)
		{
			return other != null && (other == this || (this.BJBAKJGFBGA == other.BJBAKJGFBGA && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x00144A18 File Offset: 0x00142C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BJBAKJGFBGA != LobbyCharacterType.LobbyCharacterNone)
			{
				num ^= this.BJBAKJGFBGA.GetHashCode();
			}
			if (this.Status != LobbyCharacterStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x00144A7C File Offset: 0x00142C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x00144A84 File Offset: 0x00142C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x00144A90 File Offset: 0x00142C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BJBAKJGFBGA != LobbyCharacterType.LobbyCharacterNone)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.BJBAKJGFBGA);
			}
			if (this.Status != LobbyCharacterStatus.None)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AA1 RID: 31393 RVA: 0x00144AE8 File Offset: 0x00142CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BJBAKJGFBGA != LobbyCharacterType.LobbyCharacterNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BJBAKJGFBGA);
			}
			if (this.Status != LobbyCharacterStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x00144B40 File Offset: 0x00142D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MFKOBPLMPIN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BJBAKJGFBGA != LobbyCharacterType.LobbyCharacterNone)
			{
				this.BJBAKJGFBGA = other.BJBAKJGFBGA;
			}
			if (other.Status != LobbyCharacterStatus.None)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x00144B90 File Offset: 0x00142D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x00144B9C File Offset: 0x00142D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = (LobbyCharacterStatus)input.ReadEnum();
					}
				}
				else
				{
					this.BJBAKJGFBGA = (LobbyCharacterType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002F0C RID: 12044
		private static readonly MessageParser<MFKOBPLMPIN> _parser = new MessageParser<MFKOBPLMPIN>(() => new MFKOBPLMPIN());

		// Token: 0x04002F0D RID: 12045
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F0E RID: 12046
		public const int BJBAKJGFBGAFieldNumber = 1;

		// Token: 0x04002F0F RID: 12047
		private LobbyCharacterType bJBAKJGFBGA_;

		// Token: 0x04002F10 RID: 12048
		public const int StatusFieldNumber = 2;

		// Token: 0x04002F11 RID: 12049
		private LobbyCharacterStatus status_;
	}
}
