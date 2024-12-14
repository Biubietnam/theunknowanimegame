using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002B1 RID: 689
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueUpdateDicePassiveAccumulateValueScNotify : IMessage<ChessRogueUpdateDicePassiveAccumulateValueScNotify>, IMessage, IEquatable<ChessRogueUpdateDicePassiveAccumulateValueScNotify>, IDeepCloneable<ChessRogueUpdateDicePassiveAccumulateValueScNotify>, IBufferMessage
	{
		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00058169 File Offset: 0x00056369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueUpdateDicePassiveAccumulateValueScNotify> Parser
		{
			get
			{
				return ChessRogueUpdateDicePassiveAccumulateValueScNotify._parser;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00058170 File Offset: 0x00056370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateDicePassiveAccumulateValueScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00058182 File Offset: 0x00056382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueUpdateDicePassiveAccumulateValueScNotify.Descriptor;
			}
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00058189 File Offset: 0x00056389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateDicePassiveAccumulateValueScNotify()
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00058191 File Offset: 0x00056391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateDicePassiveAccumulateValueScNotify(ChessRogueUpdateDicePassiveAccumulateValueScNotify other) : this()
		{
			this.passiveValue_ = other.passiveValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x000581B6 File Offset: 0x000563B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateDicePassiveAccumulateValueScNotify Clone()
		{
			return new ChessRogueUpdateDicePassiveAccumulateValueScNotify(this);
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x000581BE File Offset: 0x000563BE
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x000581C6 File Offset: 0x000563C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassiveValue
		{
			get
			{
				return this.passiveValue_;
			}
			set
			{
				this.passiveValue_ = value;
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x000581CF File Offset: 0x000563CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueUpdateDicePassiveAccumulateValueScNotify);
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x000581DD File Offset: 0x000563DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueUpdateDicePassiveAccumulateValueScNotify other)
		{
			return other != null && (other == this || (this.PassiveValue == other.PassiveValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x0005820C File Offset: 0x0005640C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PassiveValue != 0)
			{
				num ^= this.PassiveValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0005824B File Offset: 0x0005644B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00058253 File Offset: 0x00056453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0005825C File Offset: 0x0005645C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PassiveValue != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PassiveValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00058290 File Offset: 0x00056490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PassiveValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassiveValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000582CE File Offset: 0x000564CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueUpdateDicePassiveAccumulateValueScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PassiveValue != 0)
			{
				this.PassiveValue = other.PassiveValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000582FF File Offset: 0x000564FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00058308 File Offset: 0x00056508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PassiveValue = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000CCF RID: 3279
		private static readonly MessageParser<ChessRogueUpdateDicePassiveAccumulateValueScNotify> _parser = new MessageParser<ChessRogueUpdateDicePassiveAccumulateValueScNotify>(() => new ChessRogueUpdateDicePassiveAccumulateValueScNotify());

		// Token: 0x04000CD0 RID: 3280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CD1 RID: 3281
		public const int PassiveValueFieldNumber = 5;

		// Token: 0x04000CD2 RID: 3282
		private int passiveValue_;
	}
}
