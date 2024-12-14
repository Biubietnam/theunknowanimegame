using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FF5 RID: 4085
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournModuleInfo : IMessage<RogueTournModuleInfo>, IMessage, IEquatable<RogueTournModuleInfo>, IDeepCloneable<RogueTournModuleInfo>, IBufferMessage
	{
		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600B5C6 RID: 46534 RVA: 0x001E8020 File Offset: 0x001E6220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournModuleInfo> Parser
		{
			get
			{
				return RogueTournModuleInfo._parser;
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600B5C7 RID: 46535 RVA: 0x001E8027 File Offset: 0x001E6227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournModuleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600B5C8 RID: 46536 RVA: 0x001E8039 File Offset: 0x001E6239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournModuleInfo.Descriptor;
			}
		}

		// Token: 0x0600B5C9 RID: 46537 RVA: 0x001E8040 File Offset: 0x001E6240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournModuleInfo()
		{
		}

		// Token: 0x0600B5CA RID: 46538 RVA: 0x001E8048 File Offset: 0x001E6248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournModuleInfo(RogueTournModuleInfo other) : this()
		{
			this.allowFood_ = other.allowFood_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5CB RID: 46539 RVA: 0x001E806D File Offset: 0x001E626D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournModuleInfo Clone()
		{
			return new RogueTournModuleInfo(this);
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600B5CC RID: 46540 RVA: 0x001E8075 File Offset: 0x001E6275
		// (set) Token: 0x0600B5CD RID: 46541 RVA: 0x001E807D File Offset: 0x001E627D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AllowFood
		{
			get
			{
				return this.allowFood_;
			}
			set
			{
				this.allowFood_ = value;
			}
		}

		// Token: 0x0600B5CE RID: 46542 RVA: 0x001E8086 File Offset: 0x001E6286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournModuleInfo);
		}

		// Token: 0x0600B5CF RID: 46543 RVA: 0x001E8094 File Offset: 0x001E6294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournModuleInfo other)
		{
			return other != null && (other == this || (this.AllowFood == other.AllowFood && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B5D0 RID: 46544 RVA: 0x001E80C4 File Offset: 0x001E62C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AllowFood)
			{
				num ^= this.AllowFood.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B5D1 RID: 46545 RVA: 0x001E8103 File Offset: 0x001E6303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B5D2 RID: 46546 RVA: 0x001E810B File Offset: 0x001E630B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5D3 RID: 46547 RVA: 0x001E8114 File Offset: 0x001E6314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AllowFood)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.AllowFood);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5D4 RID: 46548 RVA: 0x001E8148 File Offset: 0x001E6348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AllowFood)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B5D5 RID: 46549 RVA: 0x001E817A File Offset: 0x001E637A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournModuleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AllowFood)
			{
				this.AllowFood = other.AllowFood;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5D6 RID: 46550 RVA: 0x001E81AB File Offset: 0x001E63AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5D7 RID: 46551 RVA: 0x001E81B4 File Offset: 0x001E63B4
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
					this.AllowFood = input.ReadBool();
				}
			}
		}

		// Token: 0x040049BE RID: 18878
		private static readonly MessageParser<RogueTournModuleInfo> _parser = new MessageParser<RogueTournModuleInfo>(() => new RogueTournModuleInfo());

		// Token: 0x040049BF RID: 18879
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049C0 RID: 18880
		public const int AllowFoodFieldNumber = 12;

		// Token: 0x040049C1 RID: 18881
		private bool allowFood_;
	}
}
