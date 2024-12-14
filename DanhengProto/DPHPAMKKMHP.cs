using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003CD RID: 973
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DPHPAMKKMHP : IMessage<DPHPAMKKMHP>, IMessage, IEquatable<DPHPAMKKMHP>, IDeepCloneable<DPHPAMKKMHP>, IBufferMessage
	{
		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x00078BE0 File Offset: 0x00076DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DPHPAMKKMHP> Parser
		{
			get
			{
				return DPHPAMKKMHP._parser;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x00078BE7 File Offset: 0x00076DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DPHPAMKKMHPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x00078BF9 File Offset: 0x00076DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DPHPAMKKMHP.Descriptor;
			}
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x00078C00 File Offset: 0x00076E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPHPAMKKMHP()
		{
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x00078C13 File Offset: 0x00076E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPHPAMKKMHP(DPHPAMKKMHP other) : this()
		{
			this.key_ = other.key_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x00078C44 File Offset: 0x00076E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPHPAMKKMHP Clone()
		{
			return new DPHPAMKKMHP(this);
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x00078C4C File Offset: 0x00076E4C
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x00078C54 File Offset: 0x00076E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x00078C67 File Offset: 0x00076E67
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x00078C6F File Offset: 0x00076E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00078C78 File Offset: 0x00076E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DPHPAMKKMHP);
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x00078C88 File Offset: 0x00076E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DPHPAMKKMHP other)
		{
			return other != null && (other == this || (!(this.Key != other.Key) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Value, other.Value) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00078CE0 File Offset: 0x00076EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key.Length != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this.Value != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Value);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x00078D45 File Offset: 0x00076F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x00078D4D File Offset: 0x00076F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00078D58 File Offset: 0x00076F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Key);
			}
			if (this.Value != 0.0)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00078DC0 File Offset: 0x00076FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
			}
			if (this.Value != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x00078E1C File Offset: 0x0007701C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DPHPAMKKMHP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key.Length != 0)
			{
				this.Key = other.Key;
			}
			if (other.Value != 0.0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x00078E7A File Offset: 0x0007707A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x00078E84 File Offset: 0x00077084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 17U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadDouble();
					}
				}
				else
				{
					this.Key = input.ReadString();
				}
			}
		}

		// Token: 0x04001197 RID: 4503
		private static readonly MessageParser<DPHPAMKKMHP> _parser = new MessageParser<DPHPAMKKMHP>(() => new DPHPAMKKMHP());

		// Token: 0x04001198 RID: 4504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001199 RID: 4505
		public const int KeyFieldNumber = 1;

		// Token: 0x0400119A RID: 4506
		private string key_ = "";

		// Token: 0x0400119B RID: 4507
		public const int ValueFieldNumber = 2;

		// Token: 0x0400119C RID: 4508
		private double value_;
	}
}
