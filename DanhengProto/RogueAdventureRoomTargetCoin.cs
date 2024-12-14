using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DED RID: 3565
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAdventureRoomTargetCoin : IMessage<RogueAdventureRoomTargetCoin>, IMessage, IEquatable<RogueAdventureRoomTargetCoin>, IDeepCloneable<RogueAdventureRoomTargetCoin>, IBufferMessage
	{
		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x06009F79 RID: 40825 RVA: 0x001AC884 File Offset: 0x001AAA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAdventureRoomTargetCoin> Parser
		{
			get
			{
				return RogueAdventureRoomTargetCoin._parser;
			}
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x06009F7A RID: 40826 RVA: 0x001AC88B File Offset: 0x001AAA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAdventureRoomTargetCoinReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x06009F7B RID: 40827 RVA: 0x001AC89D File Offset: 0x001AAA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAdventureRoomTargetCoin.Descriptor;
			}
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x001AC8A4 File Offset: 0x001AAAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetCoin()
		{
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x001AC8AC File Offset: 0x001AAAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetCoin(RogueAdventureRoomTargetCoin other) : this()
		{
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x001AC8D1 File Offset: 0x001AAAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetCoin Clone()
		{
			return new RogueAdventureRoomTargetCoin(this);
		}

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x06009F7F RID: 40831 RVA: 0x001AC8D9 File Offset: 0x001AAAD9
		// (set) Token: 0x06009F80 RID: 40832 RVA: 0x001AC8E1 File Offset: 0x001AAAE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x001AC8EA File Offset: 0x001AAAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAdventureRoomTargetCoin);
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x001AC8F8 File Offset: 0x001AAAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAdventureRoomTargetCoin other)
		{
			return other != null && (other == this || (this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F83 RID: 40835 RVA: 0x001AC928 File Offset: 0x001AAB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x001AC967 File Offset: 0x001AAB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F85 RID: 40837 RVA: 0x001AC96F File Offset: 0x001AAB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F86 RID: 40838 RVA: 0x001AC978 File Offset: 0x001AAB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F87 RID: 40839 RVA: 0x001AC9AC File Offset: 0x001AABAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F88 RID: 40840 RVA: 0x001AC9EA File Offset: 0x001AABEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAdventureRoomTargetCoin other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F89 RID: 40841 RVA: 0x001ACA1B File Offset: 0x001AAC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x001ACA24 File Offset: 0x001AAC24
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
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004178 RID: 16760
		private static readonly MessageParser<RogueAdventureRoomTargetCoin> _parser = new MessageParser<RogueAdventureRoomTargetCoin>(() => new RogueAdventureRoomTargetCoin());

		// Token: 0x04004179 RID: 16761
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400417A RID: 16762
		public const int CountFieldNumber = 6;

		// Token: 0x0400417B RID: 16763
		private int count_;
	}
}
