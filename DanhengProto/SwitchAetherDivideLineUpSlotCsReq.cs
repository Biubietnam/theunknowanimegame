using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001215 RID: 4629
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwitchAetherDivideLineUpSlotCsReq : IMessage<SwitchAetherDivideLineUpSlotCsReq>, IMessage, IEquatable<SwitchAetherDivideLineUpSlotCsReq>, IDeepCloneable<SwitchAetherDivideLineUpSlotCsReq>, IBufferMessage
	{
		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x0600CEEA RID: 52970 RVA: 0x0022AE49 File Offset: 0x00229049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwitchAetherDivideLineUpSlotCsReq> Parser
		{
			get
			{
				return SwitchAetherDivideLineUpSlotCsReq._parser;
			}
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x0600CEEB RID: 52971 RVA: 0x0022AE50 File Offset: 0x00229050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwitchAetherDivideLineUpSlotCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x0600CEEC RID: 52972 RVA: 0x0022AE62 File Offset: 0x00229062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchAetherDivideLineUpSlotCsReq.Descriptor;
			}
		}

		// Token: 0x0600CEED RID: 52973 RVA: 0x0022AE69 File Offset: 0x00229069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchAetherDivideLineUpSlotCsReq()
		{
		}

		// Token: 0x0600CEEE RID: 52974 RVA: 0x0022AE71 File Offset: 0x00229071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchAetherDivideLineUpSlotCsReq(SwitchAetherDivideLineUpSlotCsReq other) : this()
		{
			this.lineupIndex_ = other.lineupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEEF RID: 52975 RVA: 0x0022AE96 File Offset: 0x00229096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchAetherDivideLineUpSlotCsReq Clone()
		{
			return new SwitchAetherDivideLineUpSlotCsReq(this);
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x0600CEF0 RID: 52976 RVA: 0x0022AE9E File Offset: 0x0022909E
		// (set) Token: 0x0600CEF1 RID: 52977 RVA: 0x0022AEA6 File Offset: 0x002290A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LineupIndex
		{
			get
			{
				return this.lineupIndex_;
			}
			set
			{
				this.lineupIndex_ = value;
			}
		}

		// Token: 0x0600CEF2 RID: 52978 RVA: 0x0022AEAF File Offset: 0x002290AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchAetherDivideLineUpSlotCsReq);
		}

		// Token: 0x0600CEF3 RID: 52979 RVA: 0x0022AEBD File Offset: 0x002290BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchAetherDivideLineUpSlotCsReq other)
		{
			return other != null && (other == this || (this.LineupIndex == other.LineupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEF4 RID: 52980 RVA: 0x0022AEEC File Offset: 0x002290EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LineupIndex != 0U)
			{
				num ^= this.LineupIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CEF5 RID: 52981 RVA: 0x0022AF2B File Offset: 0x0022912B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CEF6 RID: 52982 RVA: 0x0022AF33 File Offset: 0x00229133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CEF7 RID: 52983 RVA: 0x0022AF3C File Offset: 0x0022913C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LineupIndex != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.LineupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CEF8 RID: 52984 RVA: 0x0022AF70 File Offset: 0x00229170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LineupIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LineupIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CEF9 RID: 52985 RVA: 0x0022AFAE File Offset: 0x002291AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchAetherDivideLineUpSlotCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LineupIndex != 0U)
			{
				this.LineupIndex = other.LineupIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CEFA RID: 52986 RVA: 0x0022AFDF File Offset: 0x002291DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEFB RID: 52987 RVA: 0x0022AFE8 File Offset: 0x002291E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LineupIndex = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005350 RID: 21328
		private static readonly MessageParser<SwitchAetherDivideLineUpSlotCsReq> _parser = new MessageParser<SwitchAetherDivideLineUpSlotCsReq>(() => new SwitchAetherDivideLineUpSlotCsReq());

		// Token: 0x04005351 RID: 21329
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005352 RID: 21330
		public const int LineupIndexFieldNumber = 7;

		// Token: 0x04005353 RID: 21331
		private uint lineupIndex_;
	}
}
