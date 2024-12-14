using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011B3 RID: 4531
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartFinishSubMissionScNotify : IMessage<StartFinishSubMissionScNotify>, IMessage, IEquatable<StartFinishSubMissionScNotify>, IDeepCloneable<StartFinishSubMissionScNotify>, IBufferMessage
	{
		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0600CA5C RID: 51804 RVA: 0x0021EEEC File Offset: 0x0021D0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartFinishSubMissionScNotify> Parser
		{
			get
			{
				return StartFinishSubMissionScNotify._parser;
			}
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0600CA5D RID: 51805 RVA: 0x0021EEF3 File Offset: 0x0021D0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartFinishSubMissionScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0600CA5E RID: 51806 RVA: 0x0021EF05 File Offset: 0x0021D105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartFinishSubMissionScNotify.Descriptor;
			}
		}

		// Token: 0x0600CA5F RID: 51807 RVA: 0x0021EF0C File Offset: 0x0021D10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFinishSubMissionScNotify()
		{
		}

		// Token: 0x0600CA60 RID: 51808 RVA: 0x0021EF14 File Offset: 0x0021D114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFinishSubMissionScNotify(StartFinishSubMissionScNotify other) : this()
		{
			this.subMissionId_ = other.subMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA61 RID: 51809 RVA: 0x0021EF39 File Offset: 0x0021D139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartFinishSubMissionScNotify Clone()
		{
			return new StartFinishSubMissionScNotify(this);
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0600CA62 RID: 51810 RVA: 0x0021EF41 File Offset: 0x0021D141
		// (set) Token: 0x0600CA63 RID: 51811 RVA: 0x0021EF49 File Offset: 0x0021D149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SubMissionId
		{
			get
			{
				return this.subMissionId_;
			}
			set
			{
				this.subMissionId_ = value;
			}
		}

		// Token: 0x0600CA64 RID: 51812 RVA: 0x0021EF52 File Offset: 0x0021D152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartFinishSubMissionScNotify);
		}

		// Token: 0x0600CA65 RID: 51813 RVA: 0x0021EF60 File Offset: 0x0021D160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartFinishSubMissionScNotify other)
		{
			return other != null && (other == this || (this.SubMissionId == other.SubMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA66 RID: 51814 RVA: 0x0021EF90 File Offset: 0x0021D190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubMissionId != 0U)
			{
				num ^= this.SubMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA67 RID: 51815 RVA: 0x0021EFCF File Offset: 0x0021D1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CA68 RID: 51816 RVA: 0x0021EFD7 File Offset: 0x0021D1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA69 RID: 51817 RVA: 0x0021EFE0 File Offset: 0x0021D1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubMissionId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.SubMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA6A RID: 51818 RVA: 0x0021F014 File Offset: 0x0021D214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA6B RID: 51819 RVA: 0x0021F052 File Offset: 0x0021D252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartFinishSubMissionScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubMissionId != 0U)
			{
				this.SubMissionId = other.SubMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA6C RID: 51820 RVA: 0x0021F083 File Offset: 0x0021D283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA6D RID: 51821 RVA: 0x0021F08C File Offset: 0x0021D28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SubMissionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040051A2 RID: 20898
		private static readonly MessageParser<StartFinishSubMissionScNotify> _parser = new MessageParser<StartFinishSubMissionScNotify>(() => new StartFinishSubMissionScNotify());

		// Token: 0x040051A3 RID: 20899
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051A4 RID: 20900
		public const int SubMissionIdFieldNumber = 13;

		// Token: 0x040051A5 RID: 20901
		private uint subMissionId_;
	}
}
