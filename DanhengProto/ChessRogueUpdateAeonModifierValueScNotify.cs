using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002A9 RID: 681
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueUpdateAeonModifierValueScNotify : IMessage<ChessRogueUpdateAeonModifierValueScNotify>, IMessage, IEquatable<ChessRogueUpdateAeonModifierValueScNotify>, IDeepCloneable<ChessRogueUpdateAeonModifierValueScNotify>, IBufferMessage
	{
		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x00057531 File Offset: 0x00055731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueUpdateAeonModifierValueScNotify> Parser
		{
			get
			{
				return ChessRogueUpdateAeonModifierValueScNotify._parser;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x00057538 File Offset: 0x00055738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateAeonModifierValueScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x0005754A File Offset: 0x0005574A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueUpdateAeonModifierValueScNotify.Descriptor;
			}
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00057551 File Offset: 0x00055751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateAeonModifierValueScNotify()
		{
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00057559 File Offset: 0x00055759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateAeonModifierValueScNotify(ChessRogueUpdateAeonModifierValueScNotify other) : this()
		{
			this.lAALOJHBPLO_ = other.lAALOJHBPLO_;
			this.aeonId_ = other.aeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0005758A File Offset: 0x0005578A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateAeonModifierValueScNotify Clone()
		{
			return new ChessRogueUpdateAeonModifierValueScNotify(this);
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x00057592 File Offset: 0x00055792
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x0005759A File Offset: 0x0005579A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LAALOJHBPLO
		{
			get
			{
				return this.lAALOJHBPLO_;
			}
			set
			{
				this.lAALOJHBPLO_ = value;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x000575A3 File Offset: 0x000557A3
		// (set) Token: 0x06001E7A RID: 7802 RVA: 0x000575AB File Offset: 0x000557AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x000575B4 File Offset: 0x000557B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueUpdateAeonModifierValueScNotify);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x000575C2 File Offset: 0x000557C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueUpdateAeonModifierValueScNotify other)
		{
			return other != null && (other == this || (this.LAALOJHBPLO == other.LAALOJHBPLO && this.AeonId == other.AeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x00057600 File Offset: 0x00055800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LAALOJHBPLO != 0)
			{
				num ^= this.LAALOJHBPLO.GetHashCode();
			}
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00057658 File Offset: 0x00055858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00057660 File Offset: 0x00055860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0005766C File Offset: 0x0005586C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.AeonId);
			}
			if (this.LAALOJHBPLO != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LAALOJHBPLO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x000576C8 File Offset: 0x000558C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LAALOJHBPLO != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LAALOJHBPLO);
			}
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00057720 File Offset: 0x00055920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueUpdateAeonModifierValueScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LAALOJHBPLO != 0)
			{
				this.LAALOJHBPLO = other.LAALOJHBPLO;
			}
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00057770 File Offset: 0x00055970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x0005777C File Offset: 0x0005597C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LAALOJHBPLO = input.ReadInt32();
					}
				}
				else
				{
					this.AeonId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000CB6 RID: 3254
		private static readonly MessageParser<ChessRogueUpdateAeonModifierValueScNotify> _parser = new MessageParser<ChessRogueUpdateAeonModifierValueScNotify>(() => new ChessRogueUpdateAeonModifierValueScNotify());

		// Token: 0x04000CB7 RID: 3255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CB8 RID: 3256
		public const int LAALOJHBPLOFieldNumber = 14;

		// Token: 0x04000CB9 RID: 3257
		private int lAALOJHBPLO_;

		// Token: 0x04000CBA RID: 3258
		public const int AeonIdFieldNumber = 6;

		// Token: 0x04000CBB RID: 3259
		private uint aeonId_;
	}
}
