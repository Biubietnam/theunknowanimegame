using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011B1 RID: 4529
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartFinishMainMissionScNotify : IMessage<StartFinishMainMissionScNotify>, IMessage, IEquatable<StartFinishMainMissionScNotify>, IDeepCloneable<StartFinishMainMissionScNotify>, IBufferMessage
	{
		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x0600CA47 RID: 51783 RVA: 0x0021EC7D File Offset: 0x0021CE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartFinishMainMissionScNotify> Parser
		{
			get
			{
				return StartFinishMainMissionScNotify._parser;
			}
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x0600CA48 RID: 51784 RVA: 0x0021EC84 File Offset: 0x0021CE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartFinishMainMissionScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x0600CA49 RID: 51785 RVA: 0x0021EC96 File Offset: 0x0021CE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartFinishMainMissionScNotify.Descriptor;
			}
		}

		// Token: 0x0600CA4A RID: 51786 RVA: 0x0021EC9D File Offset: 0x0021CE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFinishMainMissionScNotify()
		{
		}

		// Token: 0x0600CA4B RID: 51787 RVA: 0x0021ECA5 File Offset: 0x0021CEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFinishMainMissionScNotify(StartFinishMainMissionScNotify other) : this()
		{
			this.mainMissionId_ = other.mainMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA4C RID: 51788 RVA: 0x0021ECCA File Offset: 0x0021CECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFinishMainMissionScNotify Clone()
		{
			return new StartFinishMainMissionScNotify(this);
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x0600CA4D RID: 51789 RVA: 0x0021ECD2 File Offset: 0x0021CED2
		// (set) Token: 0x0600CA4E RID: 51790 RVA: 0x0021ECDA File Offset: 0x0021CEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainMissionId
		{
			get
			{
				return this.mainMissionId_;
			}
			set
			{
				this.mainMissionId_ = value;
			}
		}

		// Token: 0x0600CA4F RID: 51791 RVA: 0x0021ECE3 File Offset: 0x0021CEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartFinishMainMissionScNotify);
		}

		// Token: 0x0600CA50 RID: 51792 RVA: 0x0021ECF1 File Offset: 0x0021CEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartFinishMainMissionScNotify other)
		{
			return other != null && (other == this || (this.MainMissionId == other.MainMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA51 RID: 51793 RVA: 0x0021ED20 File Offset: 0x0021CF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MainMissionId != 0U)
			{
				num ^= this.MainMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA52 RID: 51794 RVA: 0x0021ED5F File Offset: 0x0021CF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CA53 RID: 51795 RVA: 0x0021ED67 File Offset: 0x0021CF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA54 RID: 51796 RVA: 0x0021ED70 File Offset: 0x0021CF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainMissionId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA55 RID: 51797 RVA: 0x0021EDA4 File Offset: 0x0021CFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MainMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA56 RID: 51798 RVA: 0x0021EDE2 File Offset: 0x0021CFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartFinishMainMissionScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MainMissionId != 0U)
			{
				this.MainMissionId = other.MainMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA57 RID: 51799 RVA: 0x0021EE13 File Offset: 0x0021D013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA58 RID: 51800 RVA: 0x0021EE1C File Offset: 0x0021D01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MainMissionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400519D RID: 20893
		private static readonly MessageParser<StartFinishMainMissionScNotify> _parser = new MessageParser<StartFinishMainMissionScNotify>(() => new StartFinishMainMissionScNotify());

		// Token: 0x0400519E RID: 20894
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400519F RID: 20895
		public const int MainMissionIdFieldNumber = 15;

		// Token: 0x040051A0 RID: 20896
		private uint mainMissionId_;
	}
}
