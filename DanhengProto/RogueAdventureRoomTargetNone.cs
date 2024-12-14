using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DF1 RID: 3569
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAdventureRoomTargetNone : IMessage<RogueAdventureRoomTargetNone>, IMessage, IEquatable<RogueAdventureRoomTargetNone>, IDeepCloneable<RogueAdventureRoomTargetNone>, IBufferMessage
	{
		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x06009FA3 RID: 40867 RVA: 0x001ACD57 File Offset: 0x001AAF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAdventureRoomTargetNone> Parser
		{
			get
			{
				return RogueAdventureRoomTargetNone._parser;
			}
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x06009FA4 RID: 40868 RVA: 0x001ACD5E File Offset: 0x001AAF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAdventureRoomTargetNoneReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x06009FA5 RID: 40869 RVA: 0x001ACD70 File Offset: 0x001AAF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAdventureRoomTargetNone.Descriptor;
			}
		}

		// Token: 0x06009FA6 RID: 40870 RVA: 0x001ACD77 File Offset: 0x001AAF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetNone()
		{
		}

		// Token: 0x06009FA7 RID: 40871 RVA: 0x001ACD7F File Offset: 0x001AAF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetNone(RogueAdventureRoomTargetNone other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x001ACD98 File Offset: 0x001AAF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetNone Clone()
		{
			return new RogueAdventureRoomTargetNone(this);
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x001ACDA0 File Offset: 0x001AAFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAdventureRoomTargetNone);
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x001ACDAE File Offset: 0x001AAFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAdventureRoomTargetNone other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009FAB RID: 40875 RVA: 0x001ACDCC File Offset: 0x001AAFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FAC RID: 40876 RVA: 0x001ACDF2 File Offset: 0x001AAFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x001ACDFA File Offset: 0x001AAFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FAE RID: 40878 RVA: 0x001ACE03 File Offset: 0x001AB003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FAF RID: 40879 RVA: 0x001ACE1C File Offset: 0x001AB01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FB0 RID: 40880 RVA: 0x001ACE42 File Offset: 0x001AB042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAdventureRoomTargetNone other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FB1 RID: 40881 RVA: 0x001ACE5F File Offset: 0x001AB05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FB2 RID: 40882 RVA: 0x001ACE68 File Offset: 0x001AB068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004182 RID: 16770
		private static readonly MessageParser<RogueAdventureRoomTargetNone> _parser = new MessageParser<RogueAdventureRoomTargetNone>(() => new RogueAdventureRoomTargetNone());

		// Token: 0x04004183 RID: 16771
		private UnknownFieldSet _unknownFields;
	}
}
