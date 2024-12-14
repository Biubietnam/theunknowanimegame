using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DF3 RID: 3571
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAdventureRoomTargetRuanmei : IMessage<RogueAdventureRoomTargetRuanmei>, IMessage, IEquatable<RogueAdventureRoomTargetRuanmei>, IDeepCloneable<RogueAdventureRoomTargetRuanmei>, IBufferMessage
	{
		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x06009FB6 RID: 40886 RVA: 0x001ACF0B File Offset: 0x001AB10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAdventureRoomTargetRuanmei> Parser
		{
			get
			{
				return RogueAdventureRoomTargetRuanmei._parser;
			}
		}

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x06009FB7 RID: 40887 RVA: 0x001ACF12 File Offset: 0x001AB112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAdventureRoomTargetRuanmeiReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x06009FB8 RID: 40888 RVA: 0x001ACF24 File Offset: 0x001AB124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAdventureRoomTargetRuanmei.Descriptor;
			}
		}

		// Token: 0x06009FB9 RID: 40889 RVA: 0x001ACF2B File Offset: 0x001AB12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetRuanmei()
		{
		}

		// Token: 0x06009FBA RID: 40890 RVA: 0x001ACF33 File Offset: 0x001AB133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetRuanmei(RogueAdventureRoomTargetRuanmei other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FBB RID: 40891 RVA: 0x001ACF4C File Offset: 0x001AB14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetRuanmei Clone()
		{
			return new RogueAdventureRoomTargetRuanmei(this);
		}

		// Token: 0x06009FBC RID: 40892 RVA: 0x001ACF54 File Offset: 0x001AB154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAdventureRoomTargetRuanmei);
		}

		// Token: 0x06009FBD RID: 40893 RVA: 0x001ACF62 File Offset: 0x001AB162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAdventureRoomTargetRuanmei other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009FBE RID: 40894 RVA: 0x001ACF80 File Offset: 0x001AB180
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

		// Token: 0x06009FBF RID: 40895 RVA: 0x001ACFA6 File Offset: 0x001AB1A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x001ACFAE File Offset: 0x001AB1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FC1 RID: 40897 RVA: 0x001ACFB7 File Offset: 0x001AB1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x001ACFD0 File Offset: 0x001AB1D0
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

		// Token: 0x06009FC3 RID: 40899 RVA: 0x001ACFF6 File Offset: 0x001AB1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAdventureRoomTargetRuanmei other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FC4 RID: 40900 RVA: 0x001AD013 File Offset: 0x001AB213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FC5 RID: 40901 RVA: 0x001AD01C File Offset: 0x001AB21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004185 RID: 16773
		private static readonly MessageParser<RogueAdventureRoomTargetRuanmei> _parser = new MessageParser<RogueAdventureRoomTargetRuanmei>(() => new RogueAdventureRoomTargetRuanmei());

		// Token: 0x04004186 RID: 16774
		private UnknownFieldSet _unknownFields;
	}
}
