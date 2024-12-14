using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BBD RID: 3005
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumFundsChangedScNotify : IMessage<MuseumFundsChangedScNotify>, IMessage, IEquatable<MuseumFundsChangedScNotify>, IDeepCloneable<MuseumFundsChangedScNotify>, IBufferMessage
	{
		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x060084F7 RID: 34039 RVA: 0x0015EF28 File Offset: 0x0015D128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumFundsChangedScNotify> Parser
		{
			get
			{
				return MuseumFundsChangedScNotify._parser;
			}
		}

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x060084F8 RID: 34040 RVA: 0x0015EF2F File Offset: 0x0015D12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumFundsChangedScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x060084F9 RID: 34041 RVA: 0x0015EF41 File Offset: 0x0015D141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumFundsChangedScNotify.Descriptor;
			}
		}

		// Token: 0x060084FA RID: 34042 RVA: 0x0015EF48 File Offset: 0x0015D148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumFundsChangedScNotify()
		{
		}

		// Token: 0x060084FB RID: 34043 RVA: 0x0015EF50 File Offset: 0x0015D150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumFundsChangedScNotify(MuseumFundsChangedScNotify other) : this()
		{
			this.mMIDJEHMHMP_ = other.mMIDJEHMHMP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084FC RID: 34044 RVA: 0x0015EF75 File Offset: 0x0015D175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumFundsChangedScNotify Clone()
		{
			return new MuseumFundsChangedScNotify(this);
		}

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x060084FD RID: 34045 RVA: 0x0015EF7D File Offset: 0x0015D17D
		// (set) Token: 0x060084FE RID: 34046 RVA: 0x0015EF85 File Offset: 0x0015D185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMIDJEHMHMP
		{
			get
			{
				return this.mMIDJEHMHMP_;
			}
			set
			{
				this.mMIDJEHMHMP_ = value;
			}
		}

		// Token: 0x060084FF RID: 34047 RVA: 0x0015EF8E File Offset: 0x0015D18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumFundsChangedScNotify);
		}

		// Token: 0x06008500 RID: 34048 RVA: 0x0015EF9C File Offset: 0x0015D19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumFundsChangedScNotify other)
		{
			return other != null && (other == this || (this.MMIDJEHMHMP == other.MMIDJEHMHMP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008501 RID: 34049 RVA: 0x0015EFCC File Offset: 0x0015D1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MMIDJEHMHMP != 0U)
			{
				num ^= this.MMIDJEHMHMP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008502 RID: 34050 RVA: 0x0015F00B File Offset: 0x0015D20B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008503 RID: 34051 RVA: 0x0015F013 File Offset: 0x0015D213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008504 RID: 34052 RVA: 0x0015F01C File Offset: 0x0015D21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MMIDJEHMHMP != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MMIDJEHMHMP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008505 RID: 34053 RVA: 0x0015F050 File Offset: 0x0015D250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MMIDJEHMHMP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMIDJEHMHMP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008506 RID: 34054 RVA: 0x0015F08E File Offset: 0x0015D28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumFundsChangedScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MMIDJEHMHMP != 0U)
			{
				this.MMIDJEHMHMP = other.MMIDJEHMHMP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008507 RID: 34055 RVA: 0x0015F0BF File Offset: 0x0015D2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008508 RID: 34056 RVA: 0x0015F0C8 File Offset: 0x0015D2C8
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
					this.MMIDJEHMHMP = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040032E8 RID: 13032
		private static readonly MessageParser<MuseumFundsChangedScNotify> _parser = new MessageParser<MuseumFundsChangedScNotify>(() => new MuseumFundsChangedScNotify());

		// Token: 0x040032E9 RID: 13033
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032EA RID: 13034
		public const int MMIDJEHMHMPFieldNumber = 7;

		// Token: 0x040032EB RID: 13035
		private uint mMIDJEHMHMP_;
	}
}
