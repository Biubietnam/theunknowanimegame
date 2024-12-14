using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001309 RID: 4873
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakePrestigeRewardCsReq : IMessage<TakePrestigeRewardCsReq>, IMessage, IEquatable<TakePrestigeRewardCsReq>, IDeepCloneable<TakePrestigeRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x0600D964 RID: 55652 RVA: 0x0024344C File Offset: 0x0024164C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakePrestigeRewardCsReq> Parser
		{
			get
			{
				return TakePrestigeRewardCsReq._parser;
			}
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x0600D965 RID: 55653 RVA: 0x00243453 File Offset: 0x00241653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakePrestigeRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x0600D966 RID: 55654 RVA: 0x00243465 File Offset: 0x00241665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakePrestigeRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D967 RID: 55655 RVA: 0x0024346C File Offset: 0x0024166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePrestigeRewardCsReq()
		{
		}

		// Token: 0x0600D968 RID: 55656 RVA: 0x00243474 File Offset: 0x00241674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePrestigeRewardCsReq(TakePrestigeRewardCsReq other) : this()
		{
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D969 RID: 55657 RVA: 0x00243499 File Offset: 0x00241699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePrestigeRewardCsReq Clone()
		{
			return new TakePrestigeRewardCsReq(this);
		}

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x0600D96A RID: 55658 RVA: 0x002434A1 File Offset: 0x002416A1
		// (set) Token: 0x0600D96B RID: 55659 RVA: 0x002434A9 File Offset: 0x002416A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600D96C RID: 55660 RVA: 0x002434B2 File Offset: 0x002416B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakePrestigeRewardCsReq);
		}

		// Token: 0x0600D96D RID: 55661 RVA: 0x002434C0 File Offset: 0x002416C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakePrestigeRewardCsReq other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D96E RID: 55662 RVA: 0x002434F0 File Offset: 0x002416F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D96F RID: 55663 RVA: 0x0024352F File Offset: 0x0024172F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D970 RID: 55664 RVA: 0x00243537 File Offset: 0x00241737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D971 RID: 55665 RVA: 0x00243540 File Offset: 0x00241740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D972 RID: 55666 RVA: 0x00243574 File Offset: 0x00241774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D973 RID: 55667 RVA: 0x002435B2 File Offset: 0x002417B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakePrestigeRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D974 RID: 55668 RVA: 0x002435E3 File Offset: 0x002417E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D975 RID: 55669 RVA: 0x002435EC File Offset: 0x002417EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040056A4 RID: 22180
		private static readonly MessageParser<TakePrestigeRewardCsReq> _parser = new MessageParser<TakePrestigeRewardCsReq>(() => new TakePrestigeRewardCsReq());

		// Token: 0x040056A5 RID: 22181
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056A6 RID: 22182
		public const int LevelFieldNumber = 12;

		// Token: 0x040056A7 RID: 22183
		private uint level_;
	}
}
