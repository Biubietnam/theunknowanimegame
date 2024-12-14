using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000057 RID: 87
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideLineupScNotify : IMessage<AetherDivideLineupScNotify>, IMessage, IEquatable<AetherDivideLineupScNotify>, IDeepCloneable<AetherDivideLineupScNotify>, IBufferMessage
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0000B3D1 File Offset: 0x000095D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideLineupScNotify> Parser
		{
			get
			{
				return AetherDivideLineupScNotify._parser;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000B3D8 File Offset: 0x000095D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideLineupScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0000B3EA File Offset: 0x000095EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideLineupScNotify.Descriptor;
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000B3F1 File Offset: 0x000095F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideLineupScNotify()
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000B3F9 File Offset: 0x000095F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideLineupScNotify(AetherDivideLineupScNotify other) : this()
		{
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000B42E File Offset: 0x0000962E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideLineupScNotify Clone()
		{
			return new AetherDivideLineupScNotify(this);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000B436 File Offset: 0x00009636
		// (set) Token: 0x0600039C RID: 924 RVA: 0x0000B43E File Offset: 0x0000963E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideLineupInfo Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000B447 File Offset: 0x00009647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideLineupScNotify);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000B455 File Offset: 0x00009655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideLineupScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Lineup, other.Lineup) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000B488 File Offset: 0x00009688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000B4C4 File Offset: 0x000096C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000B4CC File Offset: 0x000096CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000B4D5 File Offset: 0x000096D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lineup_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000B508 File Offset: 0x00009708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000B548 File Offset: 0x00009748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideLineupScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new AetherDivideLineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000B59C File Offset: 0x0000979C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000B5A8 File Offset: 0x000097A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.lineup_ == null)
					{
						this.Lineup = new AetherDivideLineupInfo();
					}
					input.ReadMessage(this.Lineup);
				}
			}
		}

		// Token: 0x0400015F RID: 351
		private static readonly MessageParser<AetherDivideLineupScNotify> _parser = new MessageParser<AetherDivideLineupScNotify>(() => new AetherDivideLineupScNotify());

		// Token: 0x04000160 RID: 352
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000161 RID: 353
		public const int LineupFieldNumber = 14;

		// Token: 0x04000162 RID: 354
		private AetherDivideLineupInfo lineup_;
	}
}
