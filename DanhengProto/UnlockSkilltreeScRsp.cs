using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013C9 RID: 5065
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockSkilltreeScRsp : IMessage<UnlockSkilltreeScRsp>, IMessage, IEquatable<UnlockSkilltreeScRsp>, IDeepCloneable<UnlockSkilltreeScRsp>, IBufferMessage
	{
		// Token: 0x17003F6A RID: 16234
		// (get) Token: 0x0600E1C7 RID: 57799 RVA: 0x00258B79 File Offset: 0x00256D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockSkilltreeScRsp> Parser
		{
			get
			{
				return UnlockSkilltreeScRsp._parser;
			}
		}

		// Token: 0x17003F6B RID: 16235
		// (get) Token: 0x0600E1C8 RID: 57800 RVA: 0x00258B80 File Offset: 0x00256D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockSkilltreeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x0600E1C9 RID: 57801 RVA: 0x00258B92 File Offset: 0x00256D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockSkilltreeScRsp.Descriptor;
			}
		}

		// Token: 0x0600E1CA RID: 57802 RVA: 0x00258B99 File Offset: 0x00256D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockSkilltreeScRsp()
		{
		}

		// Token: 0x0600E1CB RID: 57803 RVA: 0x00258BA1 File Offset: 0x00256DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockSkilltreeScRsp(UnlockSkilltreeScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.pointId_ = other.pointId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1CC RID: 57804 RVA: 0x00258BDE File Offset: 0x00256DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockSkilltreeScRsp Clone()
		{
			return new UnlockSkilltreeScRsp(this);
		}

		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x0600E1CD RID: 57805 RVA: 0x00258BE6 File Offset: 0x00256DE6
		// (set) Token: 0x0600E1CE RID: 57806 RVA: 0x00258BEE File Offset: 0x00256DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x0600E1CF RID: 57807 RVA: 0x00258BF7 File Offset: 0x00256DF7
		// (set) Token: 0x0600E1D0 RID: 57808 RVA: 0x00258BFF File Offset: 0x00256DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PointId
		{
			get
			{
				return this.pointId_;
			}
			set
			{
				this.pointId_ = value;
			}
		}

		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x0600E1D1 RID: 57809 RVA: 0x00258C08 File Offset: 0x00256E08
		// (set) Token: 0x0600E1D2 RID: 57810 RVA: 0x00258C10 File Offset: 0x00256E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600E1D3 RID: 57811 RVA: 0x00258C19 File Offset: 0x00256E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockSkilltreeScRsp);
		}

		// Token: 0x0600E1D4 RID: 57812 RVA: 0x00258C28 File Offset: 0x00256E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockSkilltreeScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.PointId == other.PointId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1D5 RID: 57813 RVA: 0x00258C84 File Offset: 0x00256E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.PointId != 0U)
			{
				num ^= this.PointId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E1D6 RID: 57814 RVA: 0x00258CF5 File Offset: 0x00256EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E1D7 RID: 57815 RVA: 0x00258CFD File Offset: 0x00256EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1D8 RID: 57816 RVA: 0x00258D08 File Offset: 0x00256F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Level);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.PointId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.PointId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E1D9 RID: 57817 RVA: 0x00258D80 File Offset: 0x00256F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.PointId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PointId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E1DA RID: 57818 RVA: 0x00258DF0 File Offset: 0x00256FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockSkilltreeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.PointId != 0U)
			{
				this.PointId = other.PointId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E1DB RID: 57819 RVA: 0x00258E54 File Offset: 0x00257054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1DC RID: 57820 RVA: 0x00258E60 File Offset: 0x00257060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 56U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PointId = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040059D9 RID: 23001
		private static readonly MessageParser<UnlockSkilltreeScRsp> _parser = new MessageParser<UnlockSkilltreeScRsp>(() => new UnlockSkilltreeScRsp());

		// Token: 0x040059DA RID: 23002
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059DB RID: 23003
		public const int RetcodeFieldNumber = 7;

		// Token: 0x040059DC RID: 23004
		private uint retcode_;

		// Token: 0x040059DD RID: 23005
		public const int PointIdFieldNumber = 12;

		// Token: 0x040059DE RID: 23006
		private uint pointId_;

		// Token: 0x040059DF RID: 23007
		public const int LevelFieldNumber = 6;

		// Token: 0x040059E0 RID: 23008
		private uint level_;
	}
}
