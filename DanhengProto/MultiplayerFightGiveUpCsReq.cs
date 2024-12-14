using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BAD RID: 2989
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiplayerFightGiveUpCsReq : IMessage<MultiplayerFightGiveUpCsReq>, IMessage, IEquatable<MultiplayerFightGiveUpCsReq>, IDeepCloneable<MultiplayerFightGiveUpCsReq>, IBufferMessage
	{
		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x0600843B RID: 33851 RVA: 0x0015D164 File Offset: 0x0015B364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultiplayerFightGiveUpCsReq> Parser
		{
			get
			{
				return MultiplayerFightGiveUpCsReq._parser;
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x0600843C RID: 33852 RVA: 0x0015D16B File Offset: 0x0015B36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultiplayerFightGiveUpCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x0600843D RID: 33853 RVA: 0x0015D17D File Offset: 0x0015B37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiplayerFightGiveUpCsReq.Descriptor;
			}
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x0015D184 File Offset: 0x0015B384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGiveUpCsReq()
		{
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x0015D18C File Offset: 0x0015B38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGiveUpCsReq(MultiplayerFightGiveUpCsReq other) : this()
		{
			this.gCIGJDIMNCE_ = other.gCIGJDIMNCE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008440 RID: 33856 RVA: 0x0015D1B1 File Offset: 0x0015B3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGiveUpCsReq Clone()
		{
			return new MultiplayerFightGiveUpCsReq(this);
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x06008441 RID: 33857 RVA: 0x0015D1B9 File Offset: 0x0015B3B9
		// (set) Token: 0x06008442 RID: 33858 RVA: 0x0015D1C1 File Offset: 0x0015B3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong GCIGJDIMNCE
		{
			get
			{
				return this.gCIGJDIMNCE_;
			}
			set
			{
				this.gCIGJDIMNCE_ = value;
			}
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x0015D1CA File Offset: 0x0015B3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiplayerFightGiveUpCsReq);
		}

		// Token: 0x06008444 RID: 33860 RVA: 0x0015D1D8 File Offset: 0x0015B3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiplayerFightGiveUpCsReq other)
		{
			return other != null && (other == this || (this.GCIGJDIMNCE == other.GCIGJDIMNCE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008445 RID: 33861 RVA: 0x0015D208 File Offset: 0x0015B408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GCIGJDIMNCE != 0UL)
			{
				num ^= this.GCIGJDIMNCE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x0015D247 File Offset: 0x0015B447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x0015D24F File Offset: 0x0015B44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x0015D258 File Offset: 0x0015B458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GCIGJDIMNCE != 0UL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.GCIGJDIMNCE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008449 RID: 33865 RVA: 0x0015D28C File Offset: 0x0015B48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GCIGJDIMNCE != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GCIGJDIMNCE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600844A RID: 33866 RVA: 0x0015D2CA File Offset: 0x0015B4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiplayerFightGiveUpCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GCIGJDIMNCE != 0UL)
			{
				this.GCIGJDIMNCE = other.GCIGJDIMNCE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x0015D2FB File Offset: 0x0015B4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x0015D304 File Offset: 0x0015B504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GCIGJDIMNCE = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040032A4 RID: 12964
		private static readonly MessageParser<MultiplayerFightGiveUpCsReq> _parser = new MessageParser<MultiplayerFightGiveUpCsReq>(() => new MultiplayerFightGiveUpCsReq());

		// Token: 0x040032A5 RID: 12965
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032A6 RID: 12966
		public const int GCIGJDIMNCEFieldNumber = 6;

		// Token: 0x040032A7 RID: 12967
		private ulong gCIGJDIMNCE_;
	}
}
