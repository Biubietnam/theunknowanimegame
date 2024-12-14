using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200118B RID: 4491
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StarFightDataChangeNotify : IMessage<StarFightDataChangeNotify>, IMessage, IEquatable<StarFightDataChangeNotify>, IDeepCloneable<StarFightDataChangeNotify>, IBufferMessage
	{
		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600C875 RID: 51317 RVA: 0x00219D5D File Offset: 0x00217F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StarFightDataChangeNotify> Parser
		{
			get
			{
				return StarFightDataChangeNotify._parser;
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600C876 RID: 51318 RVA: 0x00219D64 File Offset: 0x00217F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StarFightDataChangeNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600C877 RID: 51319 RVA: 0x00219D76 File Offset: 0x00217F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StarFightDataChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600C878 RID: 51320 RVA: 0x00219D7D File Offset: 0x00217F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StarFightDataChangeNotify()
		{
		}

		// Token: 0x0600C879 RID: 51321 RVA: 0x00219D88 File Offset: 0x00217F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StarFightDataChangeNotify(StarFightDataChangeNotify other) : this()
		{
			this.pNDIGEEGGBL_ = ((other.pNDIGEEGGBL_ != null) ? other.pNDIGEEGGBL_.Clone() : null);
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C87A RID: 51322 RVA: 0x00219DD4 File Offset: 0x00217FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StarFightDataChangeNotify Clone()
		{
			return new StarFightDataChangeNotify(this);
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600C87B RID: 51323 RVA: 0x00219DDC File Offset: 0x00217FDC
		// (set) Token: 0x0600C87C RID: 51324 RVA: 0x00219DE4 File Offset: 0x00217FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HEFAKEFDMBL PNDIGEEGGBL
		{
			get
			{
				return this.pNDIGEEGGBL_;
			}
			set
			{
				this.pNDIGEEGGBL_ = value;
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600C87D RID: 51325 RVA: 0x00219DED File Offset: 0x00217FED
		// (set) Token: 0x0600C87E RID: 51326 RVA: 0x00219DF5 File Offset: 0x00217FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600C87F RID: 51327 RVA: 0x00219DFE File Offset: 0x00217FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StarFightDataChangeNotify);
		}

		// Token: 0x0600C880 RID: 51328 RVA: 0x00219E0C File Offset: 0x0021800C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StarFightDataChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PNDIGEEGGBL, other.PNDIGEEGGBL) && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C881 RID: 51329 RVA: 0x00219E5C File Offset: 0x0021805C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pNDIGEEGGBL_ != null)
			{
				num ^= this.PNDIGEEGGBL.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C882 RID: 51330 RVA: 0x00219EB1 File Offset: 0x002180B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C883 RID: 51331 RVA: 0x00219EB9 File Offset: 0x002180B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C884 RID: 51332 RVA: 0x00219EC4 File Offset: 0x002180C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pNDIGEEGGBL_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PNDIGEEGGBL);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x00219F20 File Offset: 0x00218120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pNDIGEEGGBL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PNDIGEEGGBL);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C886 RID: 51334 RVA: 0x00219F78 File Offset: 0x00218178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StarFightDataChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pNDIGEEGGBL_ != null)
			{
				if (this.pNDIGEEGGBL_ == null)
				{
					this.PNDIGEEGGBL = new HEFAKEFDMBL();
				}
				this.PNDIGEEGGBL.MergeFrom(other.PNDIGEEGGBL);
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C887 RID: 51335 RVA: 0x00219FE0 File Offset: 0x002181E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C888 RID: 51336 RVA: 0x00219FEC File Offset: 0x002181EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GroupId = input.ReadUInt32();
					}
				}
				else
				{
					if (this.pNDIGEEGGBL_ == null)
					{
						this.PNDIGEEGGBL = new HEFAKEFDMBL();
					}
					input.ReadMessage(this.PNDIGEEGGBL);
				}
			}
		}

		// Token: 0x040050ED RID: 20717
		private static readonly MessageParser<StarFightDataChangeNotify> _parser = new MessageParser<StarFightDataChangeNotify>(() => new StarFightDataChangeNotify());

		// Token: 0x040050EE RID: 20718
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050EF RID: 20719
		public const int PNDIGEEGGBLFieldNumber = 6;

		// Token: 0x040050F0 RID: 20720
		private HEFAKEFDMBL pNDIGEEGGBL_;

		// Token: 0x040050F1 RID: 20721
		public const int GroupIdFieldNumber = 9;

		// Token: 0x040050F2 RID: 20722
		private uint groupId_;
	}
}
