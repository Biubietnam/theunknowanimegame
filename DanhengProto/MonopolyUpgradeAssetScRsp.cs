using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B89 RID: 2953
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyUpgradeAssetScRsp : IMessage<MonopolyUpgradeAssetScRsp>, IMessage, IEquatable<MonopolyUpgradeAssetScRsp>, IDeepCloneable<MonopolyUpgradeAssetScRsp>, IBufferMessage
	{
		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x060082B0 RID: 33456 RVA: 0x001581C9 File Offset: 0x001563C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyUpgradeAssetScRsp> Parser
		{
			get
			{
				return MonopolyUpgradeAssetScRsp._parser;
			}
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x060082B1 RID: 33457 RVA: 0x001581D0 File Offset: 0x001563D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyUpgradeAssetScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x060082B2 RID: 33458 RVA: 0x001581E2 File Offset: 0x001563E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyUpgradeAssetScRsp.Descriptor;
			}
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x001581E9 File Offset: 0x001563E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyUpgradeAssetScRsp()
		{
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x001581F1 File Offset: 0x001563F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyUpgradeAssetScRsp(MonopolyUpgradeAssetScRsp other) : this()
		{
			this.cGAAJPDAFMG_ = other.cGAAJPDAFMG_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x00158222 File Offset: 0x00156422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyUpgradeAssetScRsp Clone()
		{
			return new MonopolyUpgradeAssetScRsp(this);
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x060082B6 RID: 33462 RVA: 0x0015822A File Offset: 0x0015642A
		// (set) Token: 0x060082B7 RID: 33463 RVA: 0x00158232 File Offset: 0x00156432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CGAAJPDAFMG
		{
			get
			{
				return this.cGAAJPDAFMG_;
			}
			set
			{
				this.cGAAJPDAFMG_ = value;
			}
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x060082B8 RID: 33464 RVA: 0x0015823B File Offset: 0x0015643B
		// (set) Token: 0x060082B9 RID: 33465 RVA: 0x00158243 File Offset: 0x00156443
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

		// Token: 0x060082BA RID: 33466 RVA: 0x0015824C File Offset: 0x0015644C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyUpgradeAssetScRsp);
		}

		// Token: 0x060082BB RID: 33467 RVA: 0x0015825A File Offset: 0x0015645A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyUpgradeAssetScRsp other)
		{
			return other != null && (other == this || (this.CGAAJPDAFMG == other.CGAAJPDAFMG && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082BC RID: 33468 RVA: 0x00158298 File Offset: 0x00156498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CGAAJPDAFMG != 0U)
			{
				num ^= this.CGAAJPDAFMG.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060082BD RID: 33469 RVA: 0x001582F0 File Offset: 0x001564F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060082BE RID: 33470 RVA: 0x001582F8 File Offset: 0x001564F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082BF RID: 33471 RVA: 0x00158304 File Offset: 0x00156504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CGAAJPDAFMG != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CGAAJPDAFMG);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082C0 RID: 33472 RVA: 0x00158360 File Offset: 0x00156560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CGAAJPDAFMG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CGAAJPDAFMG);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060082C1 RID: 33473 RVA: 0x001583B8 File Offset: 0x001565B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyUpgradeAssetScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CGAAJPDAFMG != 0U)
			{
				this.CGAAJPDAFMG = other.CGAAJPDAFMG;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060082C2 RID: 33474 RVA: 0x00158408 File Offset: 0x00156608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082C3 RID: 33475 RVA: 0x00158414 File Offset: 0x00156614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.CGAAJPDAFMG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040031D1 RID: 12753
		private static readonly MessageParser<MonopolyUpgradeAssetScRsp> _parser = new MessageParser<MonopolyUpgradeAssetScRsp>(() => new MonopolyUpgradeAssetScRsp());

		// Token: 0x040031D2 RID: 12754
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031D3 RID: 12755
		public const int CGAAJPDAFMGFieldNumber = 11;

		// Token: 0x040031D4 RID: 12756
		private uint cGAAJPDAFMG_;

		// Token: 0x040031D5 RID: 12757
		public const int RetcodeFieldNumber = 12;

		// Token: 0x040031D6 RID: 12758
		private uint retcode_;
	}
}
