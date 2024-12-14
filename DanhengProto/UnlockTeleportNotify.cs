using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013CB RID: 5067
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockTeleportNotify : IMessage<UnlockTeleportNotify>, IMessage, IEquatable<UnlockTeleportNotify>, IDeepCloneable<UnlockTeleportNotify>, IBufferMessage
	{
		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x0600E1E0 RID: 57824 RVA: 0x00258F5C File Offset: 0x0025715C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockTeleportNotify> Parser
		{
			get
			{
				return UnlockTeleportNotify._parser;
			}
		}

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x0600E1E1 RID: 57825 RVA: 0x00258F63 File Offset: 0x00257163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockTeleportNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x0600E1E2 RID: 57826 RVA: 0x00258F75 File Offset: 0x00257175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockTeleportNotify.Descriptor;
			}
		}

		// Token: 0x0600E1E3 RID: 57827 RVA: 0x00258F7C File Offset: 0x0025717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTeleportNotify()
		{
		}

		// Token: 0x0600E1E4 RID: 57828 RVA: 0x00258F84 File Offset: 0x00257184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTeleportNotify(UnlockTeleportNotify other) : this()
		{
			this.teleportId_ = other.teleportId_;
			this.entryId_ = other.entryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1E5 RID: 57829 RVA: 0x00258FB5 File Offset: 0x002571B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockTeleportNotify Clone()
		{
			return new UnlockTeleportNotify(this);
		}

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x0600E1E6 RID: 57830 RVA: 0x00258FBD File Offset: 0x002571BD
		// (set) Token: 0x0600E1E7 RID: 57831 RVA: 0x00258FC5 File Offset: 0x002571C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TeleportId
		{
			get
			{
				return this.teleportId_;
			}
			set
			{
				this.teleportId_ = value;
			}
		}

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x0600E1E8 RID: 57832 RVA: 0x00258FCE File Offset: 0x002571CE
		// (set) Token: 0x0600E1E9 RID: 57833 RVA: 0x00258FD6 File Offset: 0x002571D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntryId
		{
			get
			{
				return this.entryId_;
			}
			set
			{
				this.entryId_ = value;
			}
		}

		// Token: 0x0600E1EA RID: 57834 RVA: 0x00258FDF File Offset: 0x002571DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockTeleportNotify);
		}

		// Token: 0x0600E1EB RID: 57835 RVA: 0x00258FED File Offset: 0x002571ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockTeleportNotify other)
		{
			return other != null && (other == this || (this.TeleportId == other.TeleportId && this.EntryId == other.EntryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1EC RID: 57836 RVA: 0x0025902C File Offset: 0x0025722C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TeleportId != 0U)
			{
				num ^= this.TeleportId.GetHashCode();
			}
			if (this.EntryId != 0U)
			{
				num ^= this.EntryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E1ED RID: 57837 RVA: 0x00259084 File Offset: 0x00257284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E1EE RID: 57838 RVA: 0x0025908C File Offset: 0x0025728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1EF RID: 57839 RVA: 0x00259098 File Offset: 0x00257298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntryId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EntryId);
			}
			if (this.TeleportId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.TeleportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E1F0 RID: 57840 RVA: 0x002590F4 File Offset: 0x002572F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TeleportId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TeleportId);
			}
			if (this.EntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E1F1 RID: 57841 RVA: 0x0025914C File Offset: 0x0025734C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockTeleportNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TeleportId != 0U)
			{
				this.TeleportId = other.TeleportId;
			}
			if (other.EntryId != 0U)
			{
				this.EntryId = other.EntryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E1F2 RID: 57842 RVA: 0x0025919C File Offset: 0x0025739C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1F3 RID: 57843 RVA: 0x002591A8 File Offset: 0x002573A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TeleportId = input.ReadUInt32();
					}
				}
				else
				{
					this.EntryId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040059E2 RID: 23010
		private static readonly MessageParser<UnlockTeleportNotify> _parser = new MessageParser<UnlockTeleportNotify>(() => new UnlockTeleportNotify());

		// Token: 0x040059E3 RID: 23011
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059E4 RID: 23012
		public const int TeleportIdFieldNumber = 14;

		// Token: 0x040059E5 RID: 23013
		private uint teleportId_;

		// Token: 0x040059E6 RID: 23014
		public const int EntryIdFieldNumber = 12;

		// Token: 0x040059E7 RID: 23015
		private uint entryId_;
	}
}
