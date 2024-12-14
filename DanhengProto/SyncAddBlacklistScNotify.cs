using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001261 RID: 4705
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncAddBlacklistScNotify : IMessage<SyncAddBlacklistScNotify>, IMessage, IEquatable<SyncAddBlacklistScNotify>, IDeepCloneable<SyncAddBlacklistScNotify>, IBufferMessage
	{
		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x0600D210 RID: 53776 RVA: 0x002319A0 File Offset: 0x0022FBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncAddBlacklistScNotify> Parser
		{
			get
			{
				return SyncAddBlacklistScNotify._parser;
			}
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x0600D211 RID: 53777 RVA: 0x002319A7 File Offset: 0x0022FBA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncAddBlacklistScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x0600D212 RID: 53778 RVA: 0x002319B9 File Offset: 0x0022FBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncAddBlacklistScNotify.Descriptor;
			}
		}

		// Token: 0x0600D213 RID: 53779 RVA: 0x002319C0 File Offset: 0x0022FBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncAddBlacklistScNotify()
		{
		}

		// Token: 0x0600D214 RID: 53780 RVA: 0x002319C8 File Offset: 0x0022FBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncAddBlacklistScNotify(SyncAddBlacklistScNotify other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D215 RID: 53781 RVA: 0x002319ED File Offset: 0x0022FBED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncAddBlacklistScNotify Clone()
		{
			return new SyncAddBlacklistScNotify(this);
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x0600D216 RID: 53782 RVA: 0x002319F5 File Offset: 0x0022FBF5
		// (set) Token: 0x0600D217 RID: 53783 RVA: 0x002319FD File Offset: 0x0022FBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x0600D218 RID: 53784 RVA: 0x00231A06 File Offset: 0x0022FC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncAddBlacklistScNotify);
		}

		// Token: 0x0600D219 RID: 53785 RVA: 0x00231A14 File Offset: 0x0022FC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncAddBlacklistScNotify other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D21A RID: 53786 RVA: 0x00231A44 File Offset: 0x0022FC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D21B RID: 53787 RVA: 0x00231A83 File Offset: 0x0022FC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D21C RID: 53788 RVA: 0x00231A8B File Offset: 0x0022FC8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D21D RID: 53789 RVA: 0x00231A94 File Offset: 0x0022FC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D21E RID: 53790 RVA: 0x00231AC8 File Offset: 0x0022FCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D21F RID: 53791 RVA: 0x00231B06 File Offset: 0x0022FD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncAddBlacklistScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D220 RID: 53792 RVA: 0x00231B37 File Offset: 0x0022FD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D221 RID: 53793 RVA: 0x00231B40 File Offset: 0x0022FD40
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
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400543D RID: 21565
		private static readonly MessageParser<SyncAddBlacklistScNotify> _parser = new MessageParser<SyncAddBlacklistScNotify>(() => new SyncAddBlacklistScNotify());

		// Token: 0x0400543E RID: 21566
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400543F RID: 21567
		public const int UidFieldNumber = 7;

		// Token: 0x04005440 RID: 21568
		private uint uid_;
	}
}
