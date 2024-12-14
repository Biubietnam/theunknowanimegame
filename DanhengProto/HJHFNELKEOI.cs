using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008F1 RID: 2289
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HJHFNELKEOI : IMessage<HJHFNELKEOI>, IMessage, IEquatable<HJHFNELKEOI>, IDeepCloneable<HJHFNELKEOI>, IBufferMessage
	{
		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06006615 RID: 26133 RVA: 0x00110CFC File Offset: 0x0010EEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HJHFNELKEOI> Parser
		{
			get
			{
				return HJHFNELKEOI._parser;
			}
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06006616 RID: 26134 RVA: 0x00110D03 File Offset: 0x0010EF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HJHFNELKEOIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06006617 RID: 26135 RVA: 0x00110D15 File Offset: 0x0010EF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HJHFNELKEOI.Descriptor;
			}
		}

		// Token: 0x06006618 RID: 26136 RVA: 0x00110D1C File Offset: 0x0010EF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HJHFNELKEOI()
		{
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x00110D24 File Offset: 0x0010EF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HJHFNELKEOI(HJHFNELKEOI other) : this()
		{
			this.isWin_ = other.isWin_;
			this.battleEventId_ = other.battleEventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x00110D55 File Offset: 0x0010EF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HJHFNELKEOI Clone()
		{
			return new HJHFNELKEOI(this);
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x0600661B RID: 26139 RVA: 0x00110D5D File Offset: 0x0010EF5D
		// (set) Token: 0x0600661C RID: 26140 RVA: 0x00110D65 File Offset: 0x0010EF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x0600661D RID: 26141 RVA: 0x00110D6E File Offset: 0x0010EF6E
		// (set) Token: 0x0600661E RID: 26142 RVA: 0x00110D76 File Offset: 0x0010EF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BattleEventId
		{
			get
			{
				return this.battleEventId_;
			}
			set
			{
				this.battleEventId_ = value;
			}
		}

		// Token: 0x0600661F RID: 26143 RVA: 0x00110D7F File Offset: 0x0010EF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HJHFNELKEOI);
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x00110D8D File Offset: 0x0010EF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HJHFNELKEOI other)
		{
			return other != null && (other == this || (this.IsWin == other.IsWin && this.BattleEventId == other.BattleEventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x00110DCC File Offset: 0x0010EFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this.BattleEventId != 0U)
			{
				num ^= this.BattleEventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x00110E24 File Offset: 0x0010F024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x00110E2C File Offset: 0x0010F02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x00110E38 File Offset: 0x0010F038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BattleEventId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BattleEventId);
			}
			if (this.IsWin)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsWin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x00110E94 File Offset: 0x0010F094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsWin)
			{
				num += 2;
			}
			if (this.BattleEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattleEventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x00110EE0 File Offset: 0x0010F0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HJHFNELKEOI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			if (other.BattleEventId != 0U)
			{
				this.BattleEventId = other.BattleEventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x00110F30 File Offset: 0x0010F130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x00110F3C File Offset: 0x0010F13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsWin = input.ReadBool();
					}
				}
				else
				{
					this.BattleEventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400273C RID: 10044
		private static readonly MessageParser<HJHFNELKEOI> _parser = new MessageParser<HJHFNELKEOI>(() => new HJHFNELKEOI());

		// Token: 0x0400273D RID: 10045
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400273E RID: 10046
		public const int IsWinFieldNumber = 8;

		// Token: 0x0400273F RID: 10047
		private bool isWin_;

		// Token: 0x04002740 RID: 10048
		public const int BattleEventIdFieldNumber = 2;

		// Token: 0x04002741 RID: 10049
		private uint battleEventId_;
	}
}
