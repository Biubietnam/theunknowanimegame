using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001095 RID: 4245
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SecretKeyInfo : IMessage<SecretKeyInfo>, IMessage, IEquatable<SecretKeyInfo>, IDeepCloneable<SecretKeyInfo>, IBufferMessage
	{
		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600BD4B RID: 48459 RVA: 0x001FE375 File Offset: 0x001FC575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SecretKeyInfo> Parser
		{
			get
			{
				return SecretKeyInfo._parser;
			}
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600BD4C RID: 48460 RVA: 0x001FE37C File Offset: 0x001FC57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SecretKeyInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600BD4D RID: 48461 RVA: 0x001FE38E File Offset: 0x001FC58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecretKeyInfo.Descriptor;
			}
		}

		// Token: 0x0600BD4E RID: 48462 RVA: 0x001FE395 File Offset: 0x001FC595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecretKeyInfo()
		{
		}

		// Token: 0x0600BD4F RID: 48463 RVA: 0x001FE3A8 File Offset: 0x001FC5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecretKeyInfo(SecretKeyInfo other) : this()
		{
			this.secretKey_ = other.secretKey_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD50 RID: 48464 RVA: 0x001FE3D9 File Offset: 0x001FC5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecretKeyInfo Clone()
		{
			return new SecretKeyInfo(this);
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0600BD51 RID: 48465 RVA: 0x001FE3E1 File Offset: 0x001FC5E1
		// (set) Token: 0x0600BD52 RID: 48466 RVA: 0x001FE3E9 File Offset: 0x001FC5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SecretKey
		{
			get
			{
				return this.secretKey_;
			}
			set
			{
				this.secretKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0600BD53 RID: 48467 RVA: 0x001FE3FC File Offset: 0x001FC5FC
		// (set) Token: 0x0600BD54 RID: 48468 RVA: 0x001FE404 File Offset: 0x001FC604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecretKeyType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x0600BD55 RID: 48469 RVA: 0x001FE40D File Offset: 0x001FC60D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecretKeyInfo);
		}

		// Token: 0x0600BD56 RID: 48470 RVA: 0x001FE41C File Offset: 0x001FC61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecretKeyInfo other)
		{
			return other != null && (other == this || (!(this.SecretKey != other.SecretKey) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD57 RID: 48471 RVA: 0x001FE46C File Offset: 0x001FC66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SecretKey.Length != 0)
			{
				num ^= this.SecretKey.GetHashCode();
			}
			if (this.Type != SecretKeyType.SecretKeyNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD58 RID: 48472 RVA: 0x001FE4CC File Offset: 0x001FC6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BD59 RID: 48473 RVA: 0x001FE4D4 File Offset: 0x001FC6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD5A RID: 48474 RVA: 0x001FE4E0 File Offset: 0x001FC6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != SecretKeyType.SecretKeyNone)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Type);
			}
			if (this.SecretKey.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.SecretKey);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD5B RID: 48475 RVA: 0x001FE540 File Offset: 0x001FC740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SecretKey.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SecretKey);
			}
			if (this.Type != SecretKeyType.SecretKeyNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD5C RID: 48476 RVA: 0x001FE59C File Offset: 0x001FC79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecretKeyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SecretKey.Length != 0)
			{
				this.SecretKey = other.SecretKey;
			}
			if (other.Type != SecretKeyType.SecretKeyNone)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD5D RID: 48477 RVA: 0x001FE5F1 File Offset: 0x001FC7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD5E RID: 48478 RVA: 0x001FE5FC File Offset: 0x001FC7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SecretKey = input.ReadString();
					}
				}
				else
				{
					this.Type = (SecretKeyType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004CFA RID: 19706
		private static readonly MessageParser<SecretKeyInfo> _parser = new MessageParser<SecretKeyInfo>(() => new SecretKeyInfo());

		// Token: 0x04004CFB RID: 19707
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CFC RID: 19708
		public const int SecretKeyFieldNumber = 15;

		// Token: 0x04004CFD RID: 19709
		private string secretKey_ = "";

		// Token: 0x04004CFE RID: 19710
		public const int TypeFieldNumber = 4;

		// Token: 0x04004CFF RID: 19711
		private SecretKeyType type_;
	}
}
