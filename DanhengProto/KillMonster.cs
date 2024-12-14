using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009B3 RID: 2483
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KillMonster : IMessage<KillMonster>, IMessage, IEquatable<KillMonster>, IDeepCloneable<KillMonster>, IBufferMessage
	{
		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06006EF7 RID: 28407 RVA: 0x0012868C File Offset: 0x0012688C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KillMonster> Parser
		{
			get
			{
				return KillMonster._parser;
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x06006EF8 RID: 28408 RVA: 0x00128693 File Offset: 0x00126893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KillMonsterReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x06006EF9 RID: 28409 RVA: 0x001286A5 File Offset: 0x001268A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KillMonster.Descriptor;
			}
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x001286AC File Offset: 0x001268AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KillMonster()
		{
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x001286B4 File Offset: 0x001268B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KillMonster(KillMonster other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.killNum_ = other.killNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x001286E5 File Offset: 0x001268E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KillMonster Clone()
		{
			return new KillMonster(this);
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x06006EFD RID: 28413 RVA: 0x001286ED File Offset: 0x001268ED
		// (set) Token: 0x06006EFE RID: 28414 RVA: 0x001286F5 File Offset: 0x001268F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x06006EFF RID: 28415 RVA: 0x001286FE File Offset: 0x001268FE
		// (set) Token: 0x06006F00 RID: 28416 RVA: 0x00128706 File Offset: 0x00126906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KillNum
		{
			get
			{
				return this.killNum_;
			}
			set
			{
				this.killNum_ = value;
			}
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x0012870F File Offset: 0x0012690F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KillMonster);
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x0012871D File Offset: 0x0012691D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KillMonster other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.KillNum == other.KillNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x0012875C File Offset: 0x0012695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.KillNum != 0U)
			{
				num ^= this.KillNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x001287B4 File Offset: 0x001269B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x001287BC File Offset: 0x001269BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x001287C8 File Offset: 0x001269C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.MonsterId);
			}
			if (this.KillNum != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.KillNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x00128824 File Offset: 0x00126A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this.KillNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KillNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x0012887C File Offset: 0x00126A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KillMonster other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.KillNum != 0U)
			{
				this.KillNum = other.KillNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x001288CC File Offset: 0x00126ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x001288D8 File Offset: 0x00126AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.KillNum = input.ReadUInt32();
					}
				}
				else
				{
					this.MonsterId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002AA2 RID: 10914
		private static readonly MessageParser<KillMonster> _parser = new MessageParser<KillMonster>(() => new KillMonster());

		// Token: 0x04002AA3 RID: 10915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AA4 RID: 10916
		public const int MonsterIdFieldNumber = 8;

		// Token: 0x04002AA5 RID: 10917
		private uint monsterId_;

		// Token: 0x04002AA6 RID: 10918
		public const int KillNumFieldNumber = 13;

		// Token: 0x04002AA7 RID: 10919
		private uint killNum_;
	}
}
